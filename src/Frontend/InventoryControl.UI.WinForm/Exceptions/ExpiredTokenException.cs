using InventoryControl.UI.WinForms.Helpers;

namespace InventoryControl.UI.WinForms.Exceptions;

public class ExpiredTokenException : FrontendExceptionBase
{
    public ExpiredTokenException() : base("Sua sess�o expirou. Fa�a login novamente!") 
    {
        NavigationHelper.ShowLoginForm();
    }
}
