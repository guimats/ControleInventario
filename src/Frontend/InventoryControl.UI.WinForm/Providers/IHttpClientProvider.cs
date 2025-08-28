namespace InventoryControl.UI.WinForms.Providers;

public interface IHttpClientProvider
{
    HttpClient Client { get; }

    void SetTokens(string token, string refreshToken, string language = "pt-BR");

    public Task<T?> PostAsync<T>(string url, object request) where T : class;

    public Task PostAsync(string url, object request);

    public Task<T?> GetAsync<T>(string url) where T : class;

    public Task<T?> PutAsync<T>(string url, object request) where T : class;

    public Task PutAsync(string url, object request);

    public Task DeleteAsync(string url);
}
