using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Providers;
using System.Net;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.User.Auth;

public class AuthService : IAuthService
{
    private readonly IHttpClientProvider _httpClientProvider;
        
    public AuthService(IHttpClientProvider httpClientProvider) => _httpClientProvider = httpClientProvider;

    public async Task<ResponseLoginResultJson> LoginAsync(string email, string password)
    {
        var request = new RequestLoginJson
        {
            Email = email,
            Password = password
        };

        var response = await _httpClientProvider.Client.PostAsJsonAsync("login", request);

        if (response.StatusCode is HttpStatusCode.OK)
        {
            var user = await response.Content.ReadFromJsonAsync<ResponseRegisteredUserJson>();

            _httpClientProvider.SetTokens(user!.Tokens.AccessToken, user!.Tokens.RefreshToken);

            return new ResponseLoginResultJson
            {
                Valid = true,
                Message = ["Login efetuado com sucesso!"],
                User = user
            };
        }

        var errors = await response.Content.ReadFromJsonAsync<ResponseErrorJson>();

        return new ResponseLoginResultJson { Message = errors!.Errors! };
    }
}
