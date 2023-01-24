using System.Net.Http.Json;

namespace DemoRest.Client.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        public HttpService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<T> GetFromJsonAsync<T>(string? requestUri) where T : class 
        {
            return await _httpClient.GetFromJsonAsync<T>(requestUri);
        }

        public async Task PostAsJsonAsync<T>(string? requestUri, T value) where T : class
        {
            await _httpClient.PostAsJsonAsync<T>(requestUri, value);
        }
    }
}
