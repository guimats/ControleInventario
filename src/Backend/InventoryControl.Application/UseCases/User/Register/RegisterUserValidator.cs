using FluentValidation;
using InventoryControl.Exceptions;
using InventoryControl.Communication.Requests;

namespace InventoryControl.Application.UseCases.User.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestRegisterUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_NAME);
            RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_EMAIL);
            RuleFor(user => user.Password).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_PASSWORD);
            RuleFor(user => user.Password.Length).GreaterThanOrEqualTo(6).WithMessage(ResourceMessagesException.INVALID_PASSWORD);

            When(user => string.IsNullOrEmpty(user.Email), () =>
            {
                RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessagesException.INVALID_EMAIL);
            });
        }
    }
}
