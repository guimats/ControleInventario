using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.Item.Register;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.Item.Register
{
    public class RegisterItemUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var _) = UserBuilder.Build();

            var request = RequestItemJsonBuilder.Build();

            var useCase = CreateUseCase(user);

            var result = await useCase.Execute(request);

            result.ShouldNotBeNull();
            result.Name.ShouldBe(request.Name);
        }

        [Fact]
        public async Task Error_Empty_Name()
        {
            (var user, var _) = UserBuilder.Build();

            var request = RequestItemJsonBuilder.Build();
            request.Name = string.Empty;

            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(request);

            var exceptions = await act.ShouldThrowAsync<ErrorOnValidationException>();

            exceptions.ErrorMessages.Count.ShouldBe(1);
            exceptions.ErrorMessages.ShouldContain(ResourceMessagesException.EMPTY_NAME);
        }

        private static RegisterItemUseCase CreateUseCase(InventoryControl.Domain.Entities.User user)
        {
            var repository = ItemWriteOnlyRepositoryBuilder.Build();
            var unitOfWork = UnitOfWorkBuilder.Build();
            var loggedUser = LoggedUserBuilder.Build(user);
            var mapper = MapperBuilder.Build();

            return new RegisterItemUseCase(repository, unitOfWork, loggedUser, mapper);
        }
    }
}
