using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Services.Item;

public class RegisterItemService : IRegisterItemService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public RegisterItemService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<ResponseRegisteredItemJson?> RegisterAsync(RequestItemJson request)
    {
        var response = await _httpClientProvider.Client.PostAsJsonAsync("item", request);

        if (response.StatusCode is HttpStatusCode.Created)
            return await response.Content.ReadFromJsonAsync<ResponseRegisteredItemJson>();

        var errors = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();

        throw new ErrorOnValidationException(errors!.Errors!);
    }
}
