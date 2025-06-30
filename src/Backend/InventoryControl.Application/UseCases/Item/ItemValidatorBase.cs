using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.Item
{
    public static class ItemValidatorBase
    {
        public static void Validate(RequestItemJson request)
        {
            var validator = new ItemValidator();

            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).Distinct().ToList());
            }
        }
    }
}
