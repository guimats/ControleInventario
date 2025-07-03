using CommonTestUtilities.Cryptography;
using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.User.ChangePassword;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.User.ChangePassword
{
    public class ChangePasswordUseCaseTest
    {

        [Fact]
        public async Task Success()
        {
            (var user, var password) = UserBuilder.Build();

            var request = RequestChangePasswordJsonBuilder.Build();
            request.Password = password;

            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(request);

            await act.ShouldNotThrowAsync();

            var passwordEncripter = PasswordEncripterBuilder.Build();

            user.Password.ShouldBe(passwordEncripter.Encrypt(request.NewPassword));
        }

        [Fact]
        public async Task Error_NewPassword_Empty()
        {
            (var user, var password) = UserBuilder.Build();

            var request = new RequestChangePasswordJson
            {
                Password = password,
                NewPassword = string.Empty
            };

            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(request);

            var exceptions = await act.ShouldThrowAsync<ErrorOnValidationException>();

            exceptions.ErrorMessages.Count.ShouldBe(1);
            exceptions.ErrorMessages.First().ShouldBe(ResourceMessagesException.EMPTY_PASSWORD);
        }

        [Fact]
        public async Task Error_CurrentPassword_Different()
        {
            (var user, var password) = UserBuilder.Build();

            var request = RequestChangePasswordJsonBuilder.Build();

            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(request);

            var exceptions = await act.ShouldThrowAsync<ErrorOnValidationException>();

            exceptions.ErrorMessages.Count.ShouldBe(1);
            exceptions.ErrorMessages.First().ShouldBe(ResourceMessagesException.PASSWORD_DIFFERENT_CURRENT_PASSWORD);
        }

        private static ChangePasswordUseCase CreateUseCase(InventoryControl.Domain.Entities.User user)
        {
            var repository = new UserUpdateOnlyRepositoryBuilder().GetById(user).Build();
            var unitOfWork = UnitOfWorkBuilder.Build();
            var passwordEncripter = PasswordEncripterBuilder.Build();
            var loggedUser = LoggedUserBuilder.Build(user);

            return new ChangePasswordUseCase(repository, unitOfWork, passwordEncripter, loggedUser);
        }
    }
}
