using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.User;

namespace InventoryControl.UI.WinForms.Services.Services.Item;

internal class DeleteItemService : IDeleteItemService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public DeleteItemService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task DeleteItemAsync(long id)
    {
        await _httpClientProvider.Client.DeleteAsync($"item/{id}");
    }
}
