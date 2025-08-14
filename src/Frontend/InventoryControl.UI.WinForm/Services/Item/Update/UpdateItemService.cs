using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Providers;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Item.Update;

public class UpdateItemService : IUpdateItemService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public UpdateItemService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task UpdateAsync(RequestItemJson request, long id)
    {
        await _httpClientProvider.PutAsync($"item/{id}", request);
    }
}
