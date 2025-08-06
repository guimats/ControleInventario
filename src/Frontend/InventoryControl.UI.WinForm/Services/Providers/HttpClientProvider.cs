using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net.Http.Headers;

namespace InventoryControl.UI.WinForms.Services.Providers;

public class HttpClientProvider : IHttpClientProvider
{
    private readonly HttpClient _httpClient;

    public HttpClientProvider()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7174")
        };
    }

    public HttpClient Client => _httpClient;

    public void SetToken(string token)
    {
        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);
    }
}
