namespace InventoryControl.UI.WinForms.Exceptions;

public class UnauthorizedException : FrontendExceptionBase
{
    public UnauthorizedException() : base("Voc� n�o tem permiss�o para executar essa a��o.") { }
}
