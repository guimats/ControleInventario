using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.Application.Services.Item.Filter;

public class FilterItensService : IFilterItensService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public FilterItensService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<ResponseItensJson?> FilterItensAsync(RequestFilterItemJson request)
    {
        var response = await _httpClientProvider.Client.PostAsJsonAsync("item/filter", request);

        if (response.StatusCode is HttpStatusCode.OK)
            return await response.Content.ReadFromJsonAsync<ResponseItensJson>();

        if (response.StatusCode is HttpStatusCode.NoContent)
            return null;

        var errors = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();

        throw new ErrorOnValidationException(errors!.Errors!);
    }
}
