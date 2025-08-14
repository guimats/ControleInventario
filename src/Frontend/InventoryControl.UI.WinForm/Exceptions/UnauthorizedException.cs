namespace InventoryControl.UI.WinForms.Exceptions;

public class UnauthorizedException : FrontendExceptionBase
{
    public UnauthorizedException() : base("Você não tem permissão para executar essa ação.") { }
}
