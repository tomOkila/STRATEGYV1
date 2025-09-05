using Blazored.LocalStorage;
using STRATEGY.CLIENT.DTOs;
using STRATEGY.CLIENT.Helpers;
using System.Net.Http;

namespace STRATEGY.WEBAPI.Helpers
{
    public class HttpClientValidator(HttpClient httpClient, ILocalStorageService localStorageService)
    {
        public string? AccessToken { get; set; }

        public HttpClient GetUnSecuredHttpClient()

        {
            //var client = _httpClientFactory.CreateClient(AppConstants.HttpClientName);
            httpClient.DefaultRequestHeaders.Remove(AppConstants.HeaderKey);
            return httpClient;
        }

        public async Task<HttpClient> GetSecuredHttpClient()
        {
            //var httpClient = _httpClientFactory.CreateClient(AppConstants.HttpClientName);
            var token = await GetTokenFromLocalStorage();
            if (!string.IsNullOrEmpty(AccessToken) && token.Token!.Equals(AccessToken)) return httpClient;

            if (token is null || token.Token is null) return httpClient;

            httpClient.DefaultRequestHeaders.Remove(AppConstants.HeaderKey);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            AccessToken = token.Token;
            return httpClient;
        }

        public async Task<LocalStorageDTO> GetTokenFromLocalStorage()
        {
            string tokenString = await localStorageService.GetItemAsStringAsync(AppConstants.StorageKey);
            if (string.IsNullOrEmpty(tokenString)) return null!;
            return SerializerOrDeserialize.Deserialize(tokenString);

        }


        public async Task<bool> SetTokenToLocalStorage(LocalStorageDTO tokenModel)
        {
            await localStorageService.SetItemAsStringAsync(AppConstants.StorageKey, SerializerOrDeserialize.Serialize(tokenModel));
            AccessToken = string.Empty;
            await GetSecuredHttpClient();
            return true;
        }
    }
}
