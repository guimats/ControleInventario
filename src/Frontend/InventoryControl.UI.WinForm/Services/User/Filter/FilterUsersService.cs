using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Providers;

namespace InventoryControl.UI.WinForms.Services.User.Filter;

public class FilterUsersService : IFilterUsersService
{
    private readonly IHttpClientProvider _httpClientProvider;

    public FilterUsersService(IHttpClientProvider httpClientProvider)
    {
        _httpClientProvider = httpClientProvider;
    }

    public Task<ResponseUsersProfilesJson?> FilterUsersAsync(RequestFilterUserJson request)
    {
        return _httpClientProvider.PostAsync<ResponseUsersProfilesJson>("user/filter", request);
    }
}
