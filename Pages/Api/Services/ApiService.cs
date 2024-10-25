using Newtonsoft.Json;

namespace atento_n3_projeto_consome_api.Pages.Api.Service
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> GetData<T> (string url)
        {
            var response = await _httpClient.GetAsync (url);
            response.EnsureSuccessStatusCode ();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
