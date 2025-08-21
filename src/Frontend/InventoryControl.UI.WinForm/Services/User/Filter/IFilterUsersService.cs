using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.User.Filter;

public interface IFilterUsersService
{
    public Task<ResponseUsersProfilesJson?> FilterUsersAsync(RequestFilterUserJson request);
}
