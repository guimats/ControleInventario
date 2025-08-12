namespace InventoryControl.UI.WinForms.Services.Interfaces.User;

public interface IHttpClientProvider
{
    HttpClient Client { get; }

    void SetToken(string token, string language = "pt-BR");
}
