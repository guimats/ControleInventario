using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Providers;

namespace InventoryControl.UI.WinForms.Services.ItemHistory;

public class ItemHistoryService : IItemHistoryService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public ItemHistoryService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<ResponseItemHistoriesJson?> GetItemHistoryAsync(long id)
    {
        return await _httpClientProvider.GetAsync<ResponseItemHistoriesJson>($"item-history/by-item/{id}");
    }
}
