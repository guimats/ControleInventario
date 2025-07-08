using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.Item.Update;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.Item.Update
{
    public class UpdateItemUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var _) = UserBuilder.Build();
            var item = ItemBuilder.Build(user);

            var useCase = CreateUseCase(user, item);

            var request = RequestItemJsonBuilder.Build();

            Func<Task> act = async () => await useCase.Execute(item.Id, request);

            await act().ShouldNotThrowAsync();
        }

        [Fact]
        public async Task Error_Invalid_Id()
        {
            (var user, var _) = UserBuilder.Build();
            var item = ItemBuilder.Build(user);
            item.Id = 0;

            var useCase = CreateUseCase(user, item);

            var request = RequestItemJsonBuilder.Build();

            Func<Task> act = async () => await useCase.Execute(item.Id, request);

            await act().ShouldThrowAsync<NotFoundException>();
        }

        public static UpdateItemUseCase CreateUseCase(
            InventoryControl.Domain.Entities.User user,
            InventoryControl.Domain.Entities.Item item)
        {
            var loggedUser = LoggedUserBuilder.Build(user);
            var repository = new ItemUpdateOnlyRepository().GetById(user,item).Build();
            var unitOfWork = UnitOfWorkBuilder.Build();
            var mapper = MapperBuilder.Build();

            return new UpdateItemUseCase(repository, unitOfWork, mapper, loggedUser);
        }
    }
}
