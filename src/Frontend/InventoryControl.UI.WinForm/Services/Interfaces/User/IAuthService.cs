using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Interfaces.User;

public interface IAuthService
{
    Task<ResponseLoginResultJson> LoginAsync(string email, string password);
}
