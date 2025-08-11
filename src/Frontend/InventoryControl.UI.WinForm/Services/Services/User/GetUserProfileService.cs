using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using InventoryControl.UI.WinForms.Services.Providers;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.Services.User;

public class GetUserProfileService : IGetUserProfileService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public GetUserProfileService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<ResponseUserProfileJson?> GetUserProfileAsync()
    {
        var response = await _httpClientProvider.Client.GetAsync("user");

        return await response.Content.ReadFromJsonAsync<ResponseUserProfileJson>();
    }
}
