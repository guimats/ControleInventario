using InventoryControl.Communication.Requests;

namespace InventoryControl.UI.WinForms.Services.Interfaces.User;

public interface IChangePasswordService
{
    public Task<bool> ChangePasswordAsync(RequestChangePasswordJson request);
}
