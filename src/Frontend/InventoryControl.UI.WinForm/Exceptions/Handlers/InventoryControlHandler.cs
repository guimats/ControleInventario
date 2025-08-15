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
                MessagesHelper.Alert(exception.GetMessages()[0]);
                return true;
            }
            return false;
        }
    }
}
