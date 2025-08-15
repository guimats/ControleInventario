
using InventoryControl.UI.WinForms.Helpers;

namespace InventoryControl.UI.WinForms.Exceptions.Handlers;

public class ExpiredTokenHandler : IExceptionHandler
{
    public bool Handle(Exception ex)
    {
        if (ex is ExpiredTokenException)
        {
            NavigationHelper.ShowLoginForm();
            return true;
        }

        return false;
    }
}
