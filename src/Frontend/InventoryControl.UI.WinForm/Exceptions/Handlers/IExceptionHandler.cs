namespace InventoryControl.UI.WinForms.Exceptions.Handlers;

public interface IExceptionHandler
{
    bool Handle(Exception ex);
}
