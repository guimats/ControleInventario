using InventoryControl.Communication.Requests;

namespace InventoryControl.UI.WinForms.Services.User.Update;

public interface IUpdateUserService
{
    public Task UpdateUser(RequestUpdateUserJson request);
}
