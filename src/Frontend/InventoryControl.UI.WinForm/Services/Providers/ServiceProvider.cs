using InventoryControl.UI.WinForms.Services.Interfaces.User;
using InventoryControl.UI.WinForms.Services.Services.User;

namespace InventoryControl.UI.WinForms.Services.Providers;

public static class ServiceProvider
{
    private static readonly IHttpClientProvider _httpClientProvider = new HttpClientProvider();
    private static readonly IAuthService _authService = new AuthService(_httpClientProvider);
    private static readonly IRegisterUserService _registerUserService = new RegisterUserService(_httpClientProvider);

    public static IHttpClientProvider HttpClientProvider => _httpClientProvider;
    public static IAuthService AuthService => _authService;
    public static IRegisterUserService RegisterUserService => _registerUserService;
}
