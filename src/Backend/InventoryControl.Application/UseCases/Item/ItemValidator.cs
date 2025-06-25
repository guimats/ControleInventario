using FluentValidation;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;

namespace InventoryControl.Application.UseCases.Item
{
    public class ItemValidator : AbstractValidator<RequestRegisterItemJson>
    {
        public ItemValidator()
        {
            RuleFor(item => item.Name).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_NAME);
            RuleFor(item => item.InternalCode).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_INTERNAL_CODE);
            RuleFor(item => item.Department).IsInEnum().WithMessage(ResourceMessagesException.DEPARTMENT_NOT_SUPORTED);
            RuleFor(item => item.ProductType).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_PRODUCT_TYPE)
                .IsInEnum().WithMessage(ResourceMessagesException.PRODUCT_TYPE_NOT_SUPORTED);
            RuleFor(item => item.ItemStatus).NotEmpty().WithMessage(ResourceMessagesException.EMPTY_ITEM_STATUS)
                .IsInEnum().WithMessage(ResourceMessagesException.ITEM_STATUS_NOT_SUPORTED);
        }
    }
}
