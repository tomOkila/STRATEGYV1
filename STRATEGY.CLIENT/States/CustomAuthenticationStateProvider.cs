using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using STRATEGY.CLIENT.DTOs;
using System.Security.Claims;
using System.Text.Json;
using STRATEGY.CLIENT.Helpers;
using System.IdentityModel.Tokens.Jwt;

namespace STRATEGY.CLIENT.States
{
    public class CustomAuthenticationStateProvider(ILocalStorageService _localStorageService) : AuthenticationStateProvider
    {
        private readonly ClaimsPrincipal anonymous = new(new ClaimsIdentity());
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var tokenModel = await GetModelFromToken();
            if (string.IsNullOrEmpty(tokenModel.Token)) return await Task.FromResult(new AuthenticationState(anonymous));

            if (!string.IsNullOrEmpty(tokenModel.Token))
            {
                //ensure the token exists in the database
                PostToken postToken = new();
                postToken.RefreshToken = tokenModel.RefreshToken;
            }

            var getUserClaims = DecryptToken(tokenModel.Token!);
            if (getUserClaims == null) { return await Task.FromResult(new AuthenticationState(anonymous)); }

            var claimsPrincipal = SetClaimPrincipal(getUserClaims);
            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }

        public async Task<LocalStorageDTO> GetModelFromToken()
        {
            try
            {
                string token = await GetBrowserLocalStorage();
                if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(token))
                    return new LocalStorageDTO();

                return DeserializeJsonString<LocalStorageDTO>(token);
            }
            catch
            {

                return new LocalStorageDTO();
            }
        }

        private async Task<string> GetBrowserLocalStorage()
        {
            var tokenModel = await _localStorageService.GetItemAsStringAsync(AppConstants.StorageKey);
            return tokenModel!;
        }

        public async Task UpdateAuthenticationState(LocalStorageDTO localStorageDTO)
        {
            var claimsPrincipal = new ClaimsPrincipal();
            if (localStorageDTO.Token != null || localStorageDTO.RefreshToken != null)
            {
                await SetBrowserLocalStorage(localStorageDTO);
                var getUserClaims = DecryptToken(localStorageDTO.Token!);
                claimsPrincipal = SetClaimPrincipal(getUserClaims);
            }
            else
            {
                await RemoveTokenFromBrowserLocalStorage();
            }
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));


        }

        public async Task SetBrowserLocalStorage(LocalStorageDTO localStorage)
        {
            try
            {
                string token = SerializeObj(localStorage);
                await _localStorageService.SetItemAsStringAsync(AppConstants.StorageKey, token);
            }
            catch { }
        }

        #region
        public static string SerializeObj<T>(T modelObject)
    => JsonSerializer.Serialize(modelObject);

        private static T DeserializeJsonString<T>(string jsonString)
            => JsonSerializer.Deserialize<T>(jsonString, JsonOptions())!;

        private static JsonSerializerOptions JsonOptions()
        {
            return new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
            };
        }

        private static UserClaimsDTO DecryptToken(string jwtToken)
        {
            try
            {
                if (string.IsNullOrEmpty(jwtToken)) return new UserClaimsDTO();
                var handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(jwtToken);

                var name = token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.Name)!.Value;
                var email = token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.Email)!.Value;
                var UserID = Convert.ToInt32(token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.NameIdentifier)!.Value);
                var Role = token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.Role)!.Value;
                var RoleName = token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.StreetAddress)!.Value;
                var PermissionsData = token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.Country)!.Value;
                var fullName = "";

                return new UserClaimsDTO(fullName, name, email, Role, RoleName, PermissionsData, UserID);
            }
            catch (Exception)
            {
                return null!;
            }
        }

        private static ClaimsPrincipal SetClaimPrincipal(UserClaimsDTO claims)
        {
            if (claims.Email is null) return new ClaimsPrincipal();
            return new ClaimsPrincipal(new ClaimsIdentity(
                new List<Claim>
                {
                    new(ClaimTypes.Name, claims.UserName!),
                    new(ClaimTypes.Email, claims.Email!),
                    new(ClaimTypes.NameIdentifier, claims.userId.ToString()!),
                    new(ClaimTypes.Role, claims.Role.ToString()!),
                    new(ClaimTypes.StreetAddress, claims.RoleName.ToString()!),
                     new(ClaimTypes.Country, claims.PermissionData.ToString()!)
                }, AppConstants.AuthenticationType));

        }

        public async Task RemoveTokenFromBrowserLocalStorage()
       => await _localStorageService.RemoveItemAsync(AppConstants.StorageKey);
        #endregion
    }
}
