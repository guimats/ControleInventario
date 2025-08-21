using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Helpers;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace InventoryControl.UI.WinForms.Providers;

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

    public void SetToken(string token, string language = "pt-BR")
    {
        _httpClient.DefaultRequestHeaders.AcceptLanguage.Clear();
        _httpClient.DefaultRequestHeaders.AcceptLanguage.Add(
            new StringWithQualityHeaderValue(language));

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);
    }

    public async Task<T?> PostAsync<T>(string url, object request) where T : class
    {
        var response = await _httpClient.PostAsJsonAsync(url, request);
        await HandleErrors(response);

        if (response.StatusCode == HttpStatusCode.NoContent)
            return null;

        return await response.Content.ReadFromJsonAsync<T>()!;
    }

    // para retornos sem conteudo
    public async Task PostAsync(string url, object request)
    {
        var response = await _httpClient.PostAsJsonAsync(url, request);
        await HandleErrors(response);
    }

    public async Task<T?> GetAsync<T>(string url) where T : class
    {
        var response = await _httpClient.GetAsync(url);

        await HandleErrors(response);

        if (response.StatusCode == HttpStatusCode.NoContent)
            return null;


        return await response.Content.ReadFromJsonAsync<T>()!;
    }

    public async Task<T?> PutAsync<T>(string url, object request) where T : class
    {
        var response = await _httpClient.PutAsJsonAsync(url, request);
        await HandleErrors(response);

        if (response.StatusCode == HttpStatusCode.NoContent)
            return null;

        return await response.Content.ReadFromJsonAsync<T>()!;
    }

    // para retornos sem conteudo
    public async Task PutAsync(string url, object request)
    {
        var response = await _httpClient.PutAsJsonAsync(url, request);
        await HandleErrors(response);
    }

    public async Task DeleteAsync(string url)
    {
        var response = await _httpClient.DeleteAsync(url);
        await HandleErrors(response);
    }

    private async static Task HandleErrors(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
            return;


        if (response.StatusCode == HttpStatusCode.InternalServerError)
            throw new Exception($"Internal error server: {await response.Content.ReadAsStringAsync()}");

        var error = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();


        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            if (error?.TokenIsExpired == true)
                throw new ExpiredTokenException();

            throw new UnauthorizedException();
        }

        throw new ErrorOnValidationException(error!.Errors!);
    }
}
