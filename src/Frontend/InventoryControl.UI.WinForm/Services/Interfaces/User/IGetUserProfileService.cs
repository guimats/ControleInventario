using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Interfaces.User;

public interface IGetUserProfileService
{
    public Task<ResponseUserProfileJson?> GetUserProfileAsync();
}
