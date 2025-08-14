using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Providers;

namespace InventoryControl.UI.WinForms.Services.User.Update;

public class UpdateUserService : IUpdateUserService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public UpdateUserService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task UpdateUser(RequestUpdateUserJson request)
    {
        await _httpClientProvider.PutAsync("user", request);
    }
}
