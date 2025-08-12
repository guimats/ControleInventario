using FluentValidation;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;

namespace InventoryControl.Application.UseCases.User.Update;

public class UpdateUserValidator : AbstractValidator<RequestUpdateUserJson>
{
    public UpdateUserValidator()
    {
        RuleFor(request => request.Name).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_NAME);
        RuleFor(request => request.Email).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_EMAIL);

        When(request => !string.IsNullOrWhiteSpace(request.Email), () => 
        { 
            RuleFor(request => request.Email).EmailAddress().WithMessage(ResourceMessagesException.INVALID_EMAIL);
        });
    }
}
