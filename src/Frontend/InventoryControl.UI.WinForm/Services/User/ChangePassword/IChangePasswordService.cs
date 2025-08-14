using InventoryControl.Communication.Requests;

namespace InventoryControl.UI.WinForms.Services.User.ChangePassword;

public interface IChangePasswordService
{
    public Task ChangePasswordAsync(RequestChangePasswordJson request);
}
