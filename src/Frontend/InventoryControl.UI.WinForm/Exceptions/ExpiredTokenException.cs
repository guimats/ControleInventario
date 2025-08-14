using InventoryControl.UI.WinForms.Helpers;

namespace InventoryControl.UI.WinForms.Exceptions;

public class ExpiredTokenException : FrontendExceptionBase
{
    public ExpiredTokenException() : base("Sua sessão expirou. Faça login novamente!") 
    {
        NavigationHelper.ShowLoginForm();
    }
}
