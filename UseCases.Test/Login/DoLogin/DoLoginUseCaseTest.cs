using CommonTestUtilities.Cryptography;
using CommonTestUtilities.Entities;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Tokens;
using InventoryControl.Application.UseCases.Login.DoLogin;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.Login.DoLogin
{
    public class DoLoginUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var password) = UserBuilder.Build();

            var request = new RequestLoginJson
            {
                Email = user.Email,
                Password = password
            };

            var useCase = CreateUseCase(user);

            var result = await useCase.Execute(request);

            result.ShouldNotBeNull();
            result.Tokens.ShouldNotBeNull();
            result.Name.Equals(user.Name);
            result.Tokens.AccessToken.ShouldNotBeEmpty();
        }

        [Fact]
        public async Task Error_Invalid_User()
        {
            (var user, var password) = UserBuilder.Build();

            var request = new RequestLoginJson
            {
                Email = "",
                Password = password
            };

            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(request);

            var exceptions = await act().ShouldThrowAsync<InvalidLoginException>();

            exceptions.Message.ShouldBe(ResourceMessagesException.EMAIL_OR_PASSWORD_INVALID);
        }

        private static DoLoginUseCase CreateUseCase(InventoryControl.Domain.Entities.User user)
        {
            var repository = new UserReadOnlyRepositoryBuilder().GetByEmailAndPassword(user).Build();
            var passwordEncripter = PasswordEncripterBuilder.Build();
            var accessTokenGenerator = JwtTokenGeneratorBuilder.Build();

            return new DoLoginUseCase(repository, passwordEncripter, accessTokenGenerator);
        }
    }
}
