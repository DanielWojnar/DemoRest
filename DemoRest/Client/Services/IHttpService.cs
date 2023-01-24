namespace DemoRest.Client.Services
{
    public interface IHttpService
    {
        public Task<T> GetFromJsonAsync<T>(string? requestUri) where T : class;
        public Task PostAsJsonAsync<T>(string? requestUri, T value) where T : class;
    }
}
