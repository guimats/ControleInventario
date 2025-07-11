using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Repositories;
using InventoryControl.Application.UseCases.Item.Delete;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.Item.Delete
{
    public class DeleteItemUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var _) = UserBuilder.Build();

            var item = ItemBuilder.Build(user);

            var useCase = CreateUseCase(user, item);

            Func<Task> act = async () => await useCase.Execute(item.Id);

            await act.ShouldNotThrowAsync();
        }

        [Fact]
        public async Task Error_Item_NotFound()
        {
            (var user, var _) = UserBuilder.Build();

            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(itemId: 1000);

            var exception = await act.ShouldThrowAsync<NotFoundException>();

            exception.Message.ShouldBe(ResourceMessagesException.ITEM_NOT_FOUND);
        }



        private static DeleteItemUseCase CreateUseCase(
            InventoryControl.Domain.Entities.User user,
            InventoryControl.Domain.Entities.Item? item = null)
        {
            var writeRepository = ItemWriteOnlyRepositoryBuilder.Build();
            var readRepository = new ItemReadOnlyRepositoryBuilder().GetById(user, item).Build();
            var loggedUser = LoggedUserBuilder.Build(user);
            var unitOfWork = UnitOfWorkBuilder.Build();

            return new DeleteItemUseCase(writeRepository, readRepository, loggedUser, unitOfWork);
        }
    }
}
