using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Providers;
using System.Net.Http.Json;

namespace InventoryControl.UI.WinForms.Services.User.GetProfile;

public class GetUserProfileService : IGetUserProfileService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public GetUserProfileService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public async Task<ResponseUserProfileJson?> GetUserProfileAsync()
    {
        return await _httpClientProvider.GetAsync<ResponseUserProfileJson>("user");
    }
}
