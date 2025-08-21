using FluentValidation;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;

namespace InventoryControl.Application.UseCases.User.Filter;

public class FilterUsersValidator : AbstractValidator<RequestFilterUserJson>
{
    public FilterUsersValidator()
    {
        RuleFor(r => r.Role).IsInEnum().WithMessage(ResourceMessagesException.ROLE_NOT_SUPORTED);
    }
}
