using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WebApi.Test
{
    public class InventoryControlClassFixture : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _httpClient;

        // criando um servidor nativo C# para execução da API em teste
        public InventoryControlClassFixture(CustomWebApplicationFactory factory) => _httpClient = factory.CreateClient();

        protected async Task<HttpResponseMessage> DoPost(string method, object request, string token = "")
        {
            AuthorizeRequest(token);

            return await _httpClient.PostAsJsonAsync(method, request);
        }

        protected async Task<HttpResponseMessage> DoGet(string method, string token = "")
        {
            AuthorizeRequest(token);

            return await _httpClient.GetAsync(method);
        }
        protected async Task<HttpResponseMessage> DoPut(string method, object request, string token)
        {
            AuthorizeRequest(token);

            return await _httpClient.PutAsJsonAsync(method, request);
        }

        private void AuthorizeRequest(string token)
        {
            if (string.IsNullOrEmpty(token))
                return;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
