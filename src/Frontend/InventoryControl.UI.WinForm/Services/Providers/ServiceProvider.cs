using InventoryControl.UI.WinForms.Services.Interfaces;
using InventoryControl.UI.WinForms.Services.Services;

namespace InventoryControl.UI.WinForms.Services.Providers;

public static class ServiceProvider
{
    private static readonly IHttpClientProvider _httpClientProvider = new HttpClientProvider();
    private static readonly IAuthService _authService = new AuthService(_httpClientProvider);

    public static IHttpClientProvider HttpClientProvider => _httpClientProvider;
    public static IAuthService AuthService => _authService;
}
