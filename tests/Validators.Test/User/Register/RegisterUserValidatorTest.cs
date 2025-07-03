using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.User.Register;
using InventoryControl.Exceptions;
using Shouldly;

namespace Validators.Test.User.Register
{
    public class RegisterUserValidatorTest
    {
        [Fact]
        public void Success()
        {
            var validator = new RegisterUserValidator();
            var request = RequestRegisterUserJsonBuilder.Build();

            var result = validator.Validate(request);
            result.IsValid.ShouldBeTrue();
        }

        [Fact]
        public void Error_Empty_Name()
        {
            var validator = new RegisterUserValidator();
            var request = RequestRegisterUserJsonBuilder.Build();
            request.Name = string.Empty;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.EMPTY_NAME));
        }

        [Fact]
        public void Error_Empty_Email()
        {
            var validator = new RegisterUserValidator();
            var request = RequestRegisterUserJsonBuilder.Build();
            request.Email = string.Empty;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.EMPTY_EMAIL));
        }

        [Fact]
        public void Error_Empty_Password()
        {
            var validator = new RegisterUserValidator();
            var request = RequestRegisterUserJsonBuilder.Build();
            request.Password = string.Empty;

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.EMPTY_PASSWORD));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void Error_Invalid_Password(int passwordLength)
        {
            var validator = new RegisterUserValidator();
            var request = RequestRegisterUserJsonBuilder.Build(passwordLength);

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.INVALID_PASSWORD));
        }

        [Fact]
        public void Error_Invalid_Email()
        {
            var validator = new RegisterUserValidator();
            var request = RequestRegisterUserJsonBuilder.Build();
            request.Email = "email.com";

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.INVALID_EMAIL));
        }
    }
}
