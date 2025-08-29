using InventoryControl.Application.UseCases.CommonValidators;
using InventoryControl.Application.UseCases.CommonValidators.ChangePassword;
using InventoryControl.Communication.Requests;
using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.Admin.ChangeUserPassword;

public class ChangeUserPassword : IChangeUserPassword
{
    public Task Execute(RequestChangePasswordJson request, long id)
    {
        ChangePasswordValidateHelper.Validate(request, )
    }
}
