using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using InventoryControl.Application.UseCases.Item.GetById;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.Item.GetById
{
    public class GetItemByIdUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var _) = UserBuilder.Build();

            var item = ItemBuilder.Build(user);

            var useCase = CreateUseCase(user, item);

            var result = await useCase.Execute(item.Id);

            result.ShouldNotBeNull();
            result.Name.ShouldNotBeNullOrEmpty();
            result.InternalCode.ShouldBe(item.InternalCode);
        }

        [Fact]
        public async Task Error_Item_NotFound()
        {
            (var user, var _) = UserBuilder.Build();

            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(itemId: 1000);

            var exceptions = await act.ShouldThrowAsync<NotFoundException>();

            exceptions.Message.ShouldBe(ResourceMessagesException.ITEM_NOT_FOUND);
        }

        private GetItemByIdUseCase CreateUseCase(
            InventoryControl.Domain.Entities.User user,
            InventoryControl.Domain.Entities.Item? item = null)
        {
            var repository = new ItemReadOnlyRepositoryBuilder().GetById(user, item).Build();
            var loggedUser = LoggedUserBuilder.Build(user);
            var mapper = MapperBuilder.Build();

            return new GetItemByIdUseCase(repository, loggedUser, mapper);
        }
    }
}
