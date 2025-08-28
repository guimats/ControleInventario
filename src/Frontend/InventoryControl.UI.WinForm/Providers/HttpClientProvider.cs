using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Exceptions;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace InventoryControl.UI.WinForms.Providers;

public class HttpClientProvider : IHttpClientProvider
{
    private readonly HttpClient _httpClient;
    private string _refreshToken = string.Empty;

    public HttpClientProvider()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7174"),
        };
    }

    public HttpClient Client => _httpClient;

    public void SetTokens(string token, string refreshToken, string language = "pt-BR")
    {
        _httpClient.DefaultRequestHeaders.AcceptLanguage.Clear();
        _httpClient.DefaultRequestHeaders.AcceptLanguage.Add(
            new StringWithQualityHeaderValue(language));

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);

        _refreshToken = refreshToken;
    }

    public async Task<T?> PostAsync<T>(string url, object request) where T : class
    {
        var response = await SendWithAuthRetry(() => _httpClient.PostAsJsonAsync(url, request));

        if(!response.IsSuccessStatusCode)
            await HandleErrors(response);

        if (response.StatusCode == HttpStatusCode.NoContent)
            return null;

        return await response.Content.ReadFromJsonAsync<T>()!;
    }

    // para retornos sem conteudo esperado
    public async Task PostAsync(string url, object request)
    {
        var response = await SendWithAuthRetry(() => _httpClient.PostAsJsonAsync(url, request));

        if (!response.IsSuccessStatusCode)
            await HandleErrors(response);
    }

    public async Task<T?> GetAsync<T>(string url) where T : class
    {
        var response = await SendWithAuthRetry(() => _httpClient.GetAsync(url));

        if (!response.IsSuccessStatusCode)
            await HandleErrors(response);

        if (response.StatusCode == HttpStatusCode.NoContent)
            return null;

        return await response.Content.ReadFromJsonAsync<T>()!;
    }

    public async Task<T?> PutAsync<T>(string url, object request) where T : class
    {
        var response = await SendWithAuthRetry(() => _httpClient.PutAsJsonAsync(url, request));

        if (!response.IsSuccessStatusCode)
            await HandleErrors(response);

        if (response.StatusCode == HttpStatusCode.NoContent)
            return null;

        return await response.Content.ReadFromJsonAsync<T>()!;
    }

    // para retornos sem conteudo esperado
    public async Task PutAsync(string url, object request)
    {
        var response = await SendWithAuthRetry(() => _httpClient.PutAsJsonAsync(url, request));

        if (!response.IsSuccessStatusCode)
            await HandleErrors(response);
    }

    public async Task DeleteAsync(string url)
    {
        var response = await SendWithAuthRetry(() => _httpClient.DeleteAsync(url));

        if (!response.IsSuccessStatusCode)
            await HandleErrors(response);
    }

    private async Task HandleErrors(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
            return;

        var content = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == HttpStatusCode.InternalServerError)
            throw new Exception($"Internal error server: {content}");

        var error = JsonSerializer.Deserialize<ResponseErrorJson>(content);


        if (response.StatusCode == HttpStatusCode.Unauthorized)
            throw new UnauthorizedException();

        throw new ErrorOnValidationException(error?.Errors!);
    }

    private async Task<bool> GenerateRefreshToken()
    {
        var request = new RequestNewTokenJson { RefreshToken = _refreshToken };

        var response = await _httpClient.PostAsJsonAsync("token/refresh-token", request);

        if (!response.IsSuccessStatusCode)
            return false;

        var tokens = await response.Content.ReadFromJsonAsync<ResponseTokensJson>()!;

        SetTokens(tokens!.AccessToken, tokens.RefreshToken);

        return true;
    }

    private async Task<HttpResponseMessage> SendWithAuthRetry(Func<Task<HttpResponseMessage>> sendRequest)
    {
        var response = await sendRequest();

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            var content = await response.Content.ReadAsStringAsync();
            var error = JsonSerializer.Deserialize<ResponseErrorJson>(content);

            var tokenIsValid = await GenerateRefreshToken();

            if (!error?.TokenIsExpired == true && tokenIsValid)
            {
                response = await sendRequest(); // refaz a mesma request
            }
        }

        return response;
    }
}
