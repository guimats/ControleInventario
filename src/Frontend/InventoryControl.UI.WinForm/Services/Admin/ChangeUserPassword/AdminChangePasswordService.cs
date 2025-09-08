using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Providers;

namespace InventoryControl.UI.WinForms.Services.Admin.ChangeUserPassword;

public class AdminChangePasswordService : IAdminChangePasswordService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public AdminChangePasswordService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task ChangePasswordAsync(RequestChangePasswordJson request, long id)
    {
        await _httpClientProvider.PutAsync($"admin/{id}/change-password", request);
    }
}
