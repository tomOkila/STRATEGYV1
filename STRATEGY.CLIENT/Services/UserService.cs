using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Models;
using STRATEGY.WEBAPI.Helpers;
using System.Net.Http.Json;

namespace STRATEGY.CLIENT.Services
{
    public class UserService(HttpClientValidator validateHttpClient) : IUserService
    {
        public async Task<GeneralResponse> CreatePermissionsAsync(Permissions model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/User/createPermission", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreatePermissionsAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> CreateRoleAsync(AppRoles model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync("api/User/createRole", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await CreateRoleAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeletePermissionsAsync(Permissions model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/User/deletePermission", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeletePermissionsAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteRoleAsync(AppRoles model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/User/deleteRole",model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteRoleAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> DeleteUserAsync(AppUsers model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PostAsJsonAsync($"api/User/deleteUser", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await DeleteUserAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<Permissions>> GetPermissionsAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/user/permissionslist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<Permissions>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetPermissionsAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<AppRoles>> GetRolesAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/user/rolelist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<AppRoles>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetRolesAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<List<GetUserDTO>> GetUsersAsync(int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.GetAsync("api/user/userlist");
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<List<GetUserDTO>>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await GetUsersAsync(SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<LoginResponse> LoginUserAsync(LoginDTO loginDTO)
        {
            var publicClient = validateHttpClient.GetUnSecuredHttpClient();
            var response = await publicClient.PostAsJsonAsync("api/User/login", loginDTO);
            string error = CheckResponseStatus(response);
            if (!string.IsNullOrEmpty(error))
                return new LoginResponse(false, error);

            var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
            return result!;
        }

        public async Task<LoginResponse> RefreshTokenAsync(PostToken model)
        {
            try
            {
                var publicClient = validateHttpClient.GetUnSecuredHttpClient();
                var response = await publicClient.PostAsJsonAsync("api/user/refresh-token", model);
                var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
                return result!;
            }
            catch (Exception ex)
            {
                return new LoginResponse(false, ex.Message);
            }
        }

        public async Task<GeneralResponse> RegisterUserAsync(RegisterUserDTO model)
        {
            var publicClient = validateHttpClient.GetUnSecuredHttpClient();
            var response = await publicClient.PostAsJsonAsync("api/user/register", model);
            var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
            return result!;
        }

        public async Task<GeneralResponse> UpdatePermissionsAsync(Permissions model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/User/updatePermission", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdatePermissionsAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> UpdateUserAsync(RegisterUserDTO model, int SessionUserId)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/User/updateuser", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(SessionUserId))
                        return null!;
                    else
                        return await UpdateUserAsync(model, SessionUserId);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<GeneralResponse> UpdateUserRoleAsync(AppRoles model)
        {
            try
            {
                var privateClient = await validateHttpClient.GetSecuredHttpClient();
                var response = await privateClient.PutAsJsonAsync("api/User/updaterole", model);
                //chcek if the token has expired
                bool checkResponseIfUnAuthorized = CheckResponse(response);
                if (!checkResponseIfUnAuthorized)
                {
                    string error = CheckResponseStatus(response);
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);

                    var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                    return result!;
                }
                else
                {
                    if (!await RequestAndSetNewToken(model.UpdatedBy))
                        return null!;
                    else
                        return await UpdateUserRoleAsync(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }


        public static string CheckResponseStatus(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
                return $"Sorry unkown error occurred.{Environment.NewLine} Error Description:{Environment.NewLine} Status Code:{response.StatusCode}{Environment.NewLine}Reason Phrase:{response.ReasonPhrase}";
            else
                return null;
        }

        private bool CheckResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                return true;
            else
                return false;
        }

        private async Task<bool> RequestAndSetNewToken(int sessionUserId)
        {

            var getToken = await validateHttpClient.GetTokenFromLocalStorage();

            var result = await validateHttpClient.GetUnSecuredHttpClient().PostAsJsonAsync("api/user/refresh-token", new PostToken() { RefreshToken = getToken.RefreshToken, SessionUserId = sessionUserId });
            var response = await result.Content.ReadFromJsonAsync<TokenResponse>();
            if (response is null) return false;
            await validateHttpClient.SetTokenToLocalStorage(new LocalStorageDTO() { Token = response.AccessToken, RefreshToken = response.RefreshToken });
            return true;
        }
    }
}
