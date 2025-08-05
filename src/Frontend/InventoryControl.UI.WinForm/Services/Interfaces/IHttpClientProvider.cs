namespace InventoryControl.UI.WinForms.Services.Interfaces;

public interface IHttpClientProvider
{
    HttpClient Client { get; }

    void SetToken(string token);
}
