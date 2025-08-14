using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Providers;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.User.ChangePassword
{
    internal class ChangePasswordService : IChangePasswordService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public ChangePasswordService(IHttpClientProvider httpClientProvider)
        {
            _httpClientProvider = httpClientProvider;
        }

        public async Task ChangePasswordAsync(RequestChangePasswordJson request)
        {
            await _httpClientProvider.PutAsync("user/change-password", request);
        }
    }
}
