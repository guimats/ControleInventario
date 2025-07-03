using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.Item;
using InventoryControl.Communication.Enums;
using InventoryControl.Exceptions;
using Shouldly;

namespace Validators.Test.Item
{
    public class ItemValidatorTest
    {
        [Fact]
        public void Success()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();

            var result = validator.Validate(request);
            result.IsValid.ShouldBeTrue();
        }

        [Fact]
        public void Error_Empty_Name()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();
            request.Name = string.Empty;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.EMPTY_NAME));
        }

        [Fact]
        public void Error_Empty_Internal_Code()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();
            request.InternalCode = string.Empty;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.EMPTY_INTERNAL_CODE));
        }

        [Fact]
        public void Error_Not_Suported_Department()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();
            request.Department = (Department)1000;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.DEPARTMENT_NOT_SUPORTED));
        }

        [Fact]
        public void Error_Empty_Product_Type()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();
            request.ProductType = null;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.EMPTY_PRODUCT_TYPE));
        }


        [Fact]
        public void Error_Not_Suported_Product_Type()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();
            request.ProductType = (ProductType)1000;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.PRODUCT_TYPE_NOT_SUPORTED));
        }


        [Fact]
        public void Error_Empty_Item_Status()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();
            request.ItemStatus = null;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.EMPTY_ITEM_STATUS));
        }

        [Fact]
        public void Error_Not_Suported_Item_Status()
        {
            var validator = new ItemValidator();
            var request = RequestItemJsonBuilder.Build();
            request.ItemStatus = (ItemStatus)1000;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.ITEM_STATUS_NOT_SUPORTED));
        }
    }
}
