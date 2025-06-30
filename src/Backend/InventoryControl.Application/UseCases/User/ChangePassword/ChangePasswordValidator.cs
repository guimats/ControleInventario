using FluentValidation;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;

namespace InventoryControl.Application.UseCases.User.ChangePassword
{
    public class ChangePasswordValidator : AbstractValidator<RequestChangePasswordJson>
    {
        public ChangePasswordValidator()
        {
            RuleFor(user => user.NewPassword).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_PASSWORD);
            When(user => !string.IsNullOrEmpty(user.NewPassword), () =>
            {
                RuleFor(user => user.NewPassword.Length).GreaterThanOrEqualTo(6).WithMessage(ResourceMessagesException.INVALID_PASSWORD);
            });
        }
    }
}
