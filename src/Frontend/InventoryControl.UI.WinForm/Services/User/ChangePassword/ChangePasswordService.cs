using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Providers;

namespace InventoryControl.UI.WinForms.Services.User.ChangePassword
{
    public class ChangePasswordService : IChangePasswordService
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
