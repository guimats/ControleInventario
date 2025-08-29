using InventoryControl.Communication.Requests;
using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.CommonValidators.ChangePassword;

public static class ChangePasswordValidateHelper
{

    public static void Validate(RequestChangePasswordJson request, Domain.Entities.User user, IPasswordEncripter passwordEncripter)
    {
        var validator = new ChangePasswordValidator();

        var result = validator.Validate(request);

        var currentPasswordEncipted = passwordEncripter.Encrypt(request.Password);

        if (!currentPasswordEncipted.Equals(user.Password))
        {
            result.Errors.Add(new FluentValidation.Results.ValidationFailure(
                string.Empty, ResourceMessagesException.PASSWORD_DIFFERENT_CURRENT_PASSWORD));
        }

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage).Distinct().ToList();

            throw new ErrorOnValidationException(errorMessages);
        }
    }
}
