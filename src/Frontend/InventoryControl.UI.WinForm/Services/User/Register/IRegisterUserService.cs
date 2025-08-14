using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.User.Register;

public interface IRegisterUserService
{
    public Task<ResponseRegisteredUserJson?> RegisterAsync(string name, string email, string password);
}
