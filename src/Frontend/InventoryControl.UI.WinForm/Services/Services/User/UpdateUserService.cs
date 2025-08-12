using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Services.User;

public class UpdateUserService : IUpdateUserService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public UpdateUserService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<bool> UpdateUser(RequestUpdateUserJson request)
    {
        var response = await _httpClientProvider.Client.PutAsJsonAsync("user", request);

        if (response.StatusCode == HttpStatusCode.NoContent)
            return true;

        var errors = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();

        throw new ErrorOnValidationException(errors!.Errors!);
    }
}
