using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.UI.WinForms.Helpers;

public static class ExceptionHandler
{
    public static async Task TryExecuteAsync(Func<Task> action)
    {
        try
        {
            await action();
        }
        catch (ErrorOnValidationException ex)
        {
            MessageBox.Show(ex.GetMessages()[0], "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
