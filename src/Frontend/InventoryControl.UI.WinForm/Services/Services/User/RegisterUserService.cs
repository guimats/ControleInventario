using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Services.User
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

            var response = await _httpClientProvider.Client.PostAsJsonAsync("user", request);

            if (response.StatusCode is HttpStatusCode.Created)
            {
                return await response.Content.ReadFromJsonAsync<ResponseRegisteredUserJson>();
            }

            var errors = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();

            throw new ErrorOnValidationException(errors!.Errors!);
        }
    }
}
