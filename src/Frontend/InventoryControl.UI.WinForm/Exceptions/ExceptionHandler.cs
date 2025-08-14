using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Helpers;

namespace InventoryControl.UI.WinForms.Exceptions;

public static class ExceptionHandler
{
    public static async Task TryExecuteAsync(Func<Task> action)
    {
        try
        {
            await action();
        }
        catch (InventoryControlException ex)
        {
            MessagesHelper.Alert(ex.GetMessages()[0]);
        }
        catch (FrontendExceptionBase ex)
        {
            MessagesHelper.Alert(ex.Message);
        }
        catch (Exception ex)
        {
            MessagesHelper.Error($"Erro inesperado: {ex.Message}");
        }
    }
}
