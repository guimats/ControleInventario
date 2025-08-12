using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Services.User
{
    internal class ChangePasswordService : IChangePasswordService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public ChangePasswordService(IHttpClientProvider httpClientProvider)
        {
            _httpClientProvider = httpClientProvider;
        }

        public async Task<bool> ChangePasswordAsync(RequestChangePasswordJson request)
        {
            var result = await _httpClientProvider.Client.PutAsJsonAsync<RequestChangePasswordJson>("user/change-password", request);

            if (result.StatusCode == HttpStatusCode.NoContent)
                return true;

            var errors = await result.Content.ReadFromJsonAsync<ResponseErrorJson>();

            throw new ErrorOnValidationException(errors!.Errors!);
        }
    }
}
