using InventoryControl.Communication.Requests;

namespace InventoryControl.UI.WinForms.Services.Admin.ChangeUserPassword;

public interface IAdminChangePasswordService
{
    public Task ChangePasswordAsync(RequestChangePasswordJson request, long id);
}
