using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.User.Register;

public interface IRegisterUserService
{
    public Task<ResponseRegisteredUserJson?> RegisterAsync(RequestRegisterUserJson request);
}
