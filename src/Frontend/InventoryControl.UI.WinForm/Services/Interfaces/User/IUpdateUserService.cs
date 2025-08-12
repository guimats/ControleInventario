using InventoryControl.Communication.Requests;

namespace InventoryControl.UI.WinForms.Services.Interfaces.User;

public interface IUpdateUserService
{
    public Task<bool> UpdateUser(RequestUpdateUserJson request);
}
