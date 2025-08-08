using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using System.Xml.Linq;

namespace InventoryControl.UI.WinForms.CommonUtilities.Validators;

public static class ValidateRequest
{
    public static void Validate(RequestItemJson request)
    {
        var requiredFields = new[] { request.Name, request.InternalCode };

        if (requiredFields.Any(string.IsNullOrWhiteSpace))
            throw new ErrorOnValidationException(["Existem campos obrigatórios sem preencher"]);
    }
}