using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.User.Auth;

public interface IAuthService
{
    Task<ResponseLoginResultJson> LoginAsync(string email, string password);
}
