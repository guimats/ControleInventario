using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.User.GetProfile;

public interface IGetUserProfileService
{
    public Task<ResponseUserProfileJson?> GetUserProfileAsync();
}
