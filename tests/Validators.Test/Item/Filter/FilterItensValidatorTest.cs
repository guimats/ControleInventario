using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.Item.Filter;
using InventoryControl.Communication.Enums;
using InventoryControl.Exceptions;
using Shouldly;

namespace Validators.Test.Item.Filter
{
    public class FilterItensValidatorTest
    {
        [Fact]
        public void Success()
        {
            var validator = new FilterItensValidator();

            var request = RequestFilterItemJsonBuilder.Build();

            var result = validator.Validate(request);

            result.IsValid.ShouldBeTrue();
        }

        [Fact]
        public void Error_Invalid_Department()
        {
            var validator = new FilterItensValidator();

            var request = RequestFilterItemJsonBuilder.Build();
            request.Departments.Add((Department)1000);

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.DEPARTMENT_NOT_SUPORTED));
        }

        [Fact]
        public void Error_Invalid_ProductType()
        {
            var validator = new FilterItensValidator();

            var request = RequestFilterItemJsonBuilder.Build();
            request.ProductTypes.Add((ProductType)1000);

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.PRODUCT_TYPE_NOT_SUPORTED));
        }

        [Fact]
        public void Error_Invalid_ItemStatus()
        {
            var validator = new FilterItensValidator();

            var request = RequestFilterItemJsonBuilder.Build();
            request.ItemStatus = (ItemStatus)1000;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.ITEM_STATUS_NOT_SUPORTED));
        }
    }
}
