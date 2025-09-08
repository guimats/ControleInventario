using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Helpers;

namespace InventoryControl.UI.WinForms.Exceptions.Handlers
{
    public class InventoryControlHandler : IExceptionHandler
    {
        public bool Handle(Exception ex)
        {
            if (ex is InventoryControlException exception)
            {
                var messages = exception.GetMessages();

                if (messages != null && messages.Count > 0)
                    MessagesHelper.Alert(messages[0]);
                else
                    MessagesHelper.Alert("Ocorreu um erro inesperado no sistema.");
                return true;
            }

            MessagesHelper.Alert($"Erro inesperado: {ex.Message}");
            return false;
        }
    }
}
