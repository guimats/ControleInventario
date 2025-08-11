using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.ItemHistory;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using InventoryControl.UI.WinForms.Services.Services.Item;
using InventoryControl.UI.WinForms.Services.Services.ItemHistory;
using InventoryControl.UI.WinForms.Services.Services.User;

namespace InventoryControl.UI.WinForms.Services.Providers;

public static class ServiceProvider
{
    private static readonly IHttpClientProvider _httpClientProvider = new HttpClientProvider();
    private static readonly IAuthService _authService = new AuthService(_httpClientProvider);
    private static readonly IRegisterUserService _registerUserService = new RegisterUserService(_httpClientProvider);
    private static readonly ISaveItemService _registerItemService = new SaveItemService(_httpClientProvider);
    private static readonly IFilterItensService _filterItensService = new FilterItensService(_httpClientProvider);
    private static readonly IDeleteItemService _deleteItemService = new DeleteItemService(_httpClientProvider);
    private static readonly IItemHistoryService _itemHistoryService = new ItemHistoryService(_httpClientProvider);
    private static readonly IGetUserProfileService _getUserProfileService = new GetUserProfileService(_httpClientProvider);


    public static IHttpClientProvider HttpClientProvider => _httpClientProvider;
    public static IAuthService AuthService => _authService;
    public static IRegisterUserService RegisterUserService => _registerUserService;
    public static ISaveItemService RegisterItemService => _registerItemService;
    public static IFilterItensService FilterItensService => _filterItensService;
    public static IDeleteItemService DeleteItemService => _deleteItemService;
    public static IItemHistoryService ItemHistoryService => _itemHistoryService;
    public static IGetUserProfileService GetUserProfileService => _getUserProfileService;

}
