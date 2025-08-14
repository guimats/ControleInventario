using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net.Http.Json;

namespace InventoryControl.UI.Application.Services.Item.Update;

public class UpdateItemService : IUpdateItemService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public UpdateItemService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task UpdateAsync(RequestItemJson request, long id)
    {
        await _httpClientProvider.Client.PutAsJsonAsync($"item/{id}", request);
    }
}
