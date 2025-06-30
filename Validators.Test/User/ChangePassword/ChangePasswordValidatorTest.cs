﻿using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.User.ChangePassword;
using InventoryControl.Exceptions;
using Shouldly;

namespace Validators.Test.User.ChangePassword
{
    public class ChangePasswordValidatorTest
    {
        [Fact]
        public void Success()
        {
            var validator = new ChangePasswordValidator();
            var request = RequestChangePasswordJsonBuilder.Build();

            var result = validator.Validate(request);

            result.IsValid.ShouldBeTrue();
        }

        [Fact]
        public void Error_Empty_NewPassword()
        {
            var validator = new ChangePasswordValidator();
            var request = RequestChangePasswordJsonBuilder.Build();
            request.NewPassword = string.Empty;

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
        public void Error_Invalid_NewPassword(int passwordLength)
        {
            var validator = new ChangePasswordValidator();
            var request = RequestChangePasswordJsonBuilder.Build(passwordLength);

            var result = validator.Validate(request);

            result.IsValid.ShouldBeFalse();
            result.Errors.Count.ShouldBe(1);
            result.Errors.ShouldContain(e => e.ErrorMessage.Equals(ResourceMessagesException.INVALID_PASSWORD));
        }
    }
}
