using InventoryControl.UI.WinForms.Helpers;
using System;

namespace InventoryControl.UI.WinForms.Exceptions.Handlers;

public class FrontendExceptionHandler : IExceptionHandler
{
    public bool Handle(Exception ex)
    {
        if (ex is FrontendExceptionBase exception)
        {
            MessagesHelper.Alert($"{exception.Message}");
            return true;
        }

        return false;
    }
}
