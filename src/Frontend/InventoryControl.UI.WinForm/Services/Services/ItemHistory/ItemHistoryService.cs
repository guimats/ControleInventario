using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Interfaces.ItemHistory;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Services.ItemHistory;

public class ItemHistoryService : IItemHistoryService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public ItemHistoryService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<ResponseItemHistoriesJson?> GetItemHistoryAsync(long id)
    {
        var response = await _httpClientProvider.Client.GetAsync($"item-history/by-item/{id}");

        if (response.StatusCode is HttpStatusCode.OK)
            return await response.Content.ReadFromJsonAsync<ResponseItemHistoriesJson>();

        if (response.StatusCode is HttpStatusCode.NotFound)
            return null;

        var errors = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();

        throw new ErrorOnValidationException(errors!.Errors!);
    }
}
