using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Providers;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Item.Filter;

public class FilterItensService : IFilterItensService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public FilterItensService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<ResponseItensJson?> FilterItensAsync(RequestFilterItemJson request)
    {
        return await _httpClientProvider.PostAsync<ResponseItensJson>("item/filter", request);
    }
}
