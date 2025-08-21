using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Providers;

namespace InventoryControl.UI.WinForms.Services.User.Register
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public RegisterUserService(IHttpClientProvider httpClientProvider) => _httpClientProvider = httpClientProvider;

        public async Task<ResponseRegisteredUserJson?> RegisterAsync(RequestRegisterUserJson request)
        {
            return await _httpClientProvider.PostAsync<ResponseRegisteredUserJson>("user", request);
        }
    }
}
