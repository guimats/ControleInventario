using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Providers;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.User.Register
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IHttpClientProvider _httpClientProvider;

        public RegisterUserService(IHttpClientProvider httpClientProvider) => _httpClientProvider = httpClientProvider;

        public async Task<ResponseRegisteredUserJson?> RegisterAsync(string name, string email, string password)
        {
            var request = new RequestRegisterUserJson
            {
                Name = name,
                Email = email,
                Password = password
            };

            return await _httpClientProvider.PostAsync<ResponseRegisteredUserJson>("user", request);
        }
    }
}
