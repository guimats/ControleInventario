using CommonTestUtilities.Cryptography;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using CommonTestUtilities.Tokens;
using InventoryControl.Application.UseCases.User.Register;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.User.Register
{
    public class RegisterUserUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            var request = RequestRegisterUserJsonBuilder.Build();
            var useCase = CreateUseCase();

            var result = await useCase.Execute(request);

            result.ShouldNotBeNull();
            result.Tokens.ShouldNotBeNull();
            result.Name.ShouldBe(request.Name);
            result.Tokens.AccessToken.ShouldNotBeNullOrEmpty();
        }

        [Fact]
        public async Task Error_Email_Already_Registered()
        {
            var request = RequestRegisterUserJsonBuilder.Build();
            var useCase = CreateUseCase(request.Email);

            Func<Task> act = async () => await useCase.Execute(request);

            var exception = await act.ShouldThrowAsync<ErrorOnValidationException>();

            exception.GetMessages().Count.ShouldBe(1);
            exception.GetMessages().First().ShouldBe(ResourceMessagesException.EMAIL_ALREADY_REGISTERED);
        }

        [Fact]
        public async Task Error_Empty_Name()
        {
            var request = RequestRegisterUserJsonBuilder.Build();
            request.Name = string.Empty;
            var useCase = CreateUseCase();

            Func<Task> act = async () => await useCase.Execute(request);

            var exception = await act.ShouldThrowAsync<ErrorOnValidationException>();

            exception.GetMessages().Count.ShouldBe(1);
            exception.GetMessages().First().ShouldBe(ResourceMessagesException.EMPTY_NAME);
        }

        private static RegisterUserUseCase CreateUseCase(string? email = null)
        {
            var writeRepository = UserWriteOnlyRepositoryBuilder.Build();
            var readRepositoryBuilder = new UserReadOnlyRepositoryBuilder();
            var unitOfWork = UnitOfWorkBuilder.Build();
            var mapper = MapperBuilder.Build();
            var passwordEncripter = PasswordEncripterBuilder.Build();
            var accessTokenGenerator = JwtTokenGeneratorBuilder.Build();

            // se email não for null, adicionar na regra do mock
            if (string.IsNullOrEmpty(email) == false)
                readRepositoryBuilder.ExistActiveUserWithEmail(email);

            return new RegisterUserUseCase(writeRepository, readRepositoryBuilder.Build(), unitOfWork, mapper, accessTokenGenerator, passwordEncripter);
        }
    }
}
