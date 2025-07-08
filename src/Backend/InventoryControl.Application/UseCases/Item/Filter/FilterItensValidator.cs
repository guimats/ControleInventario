using FluentValidation;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;

namespace InventoryControl.Application.UseCases.Item.Filter
{
    public class FilterItensValidator : AbstractValidator<RequestFilterItemJson>
    {
        public FilterItensValidator()
        {
            RuleForEach(r => r.Departments).IsInEnum().WithMessage(ResourceMessagesException.DEPARTMENT_NOT_SUPORTED);
            RuleForEach(r => r.ProductTypes).IsInEnum().WithMessage(ResourceMessagesException.PRODUCT_TYPE_NOT_SUPORTED);
            RuleFor(r => r.ItemStatus).IsInEnum().WithMessage(ResourceMessagesException.ITEM_STATUS_NOT_SUPORTED);
        }
    }
}
