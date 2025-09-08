using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.UI.WinForms.Validators;

public static class ValidateRequest
{
    public static void Validate(RequestItemJson request)
    {
        var requiredFields = new[] { request.Name, request.InternalCode };

        if (requiredFields.Any(string.IsNullOrWhiteSpace))
            throw new ErrorOnValidationException(["Existem campos obrigatórios sem preencher"]);
    }
}