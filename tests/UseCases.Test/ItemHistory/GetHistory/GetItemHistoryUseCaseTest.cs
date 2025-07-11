using Azure.Core;
using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using InventoryControl.Application.UseCases.ItemHistory.GetHistory;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.Exceptions;
using Shouldly;

namespace UseCases.Test.ItemHistory.GetHistory
{
    public class GetItemHistoryUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var _) = UserBuilder.Build();

            var item = ItemBuilder.Build(user);

            var histories = ItemHistoryBuilder.Collection(user);

            var useCase = CreateUseCase(user, histories, item);

            var result = await useCase.Execute(item.Id);

            result.ShouldNotBeNull();
        }

        [Fact]
        public async Task Error_Item_NotFound()
        {
            (var user, var _) = UserBuilder.Build();
            var useCase = CreateUseCase(user);

            Func<Task> act = async () => await useCase.Execute(id: 1000);

            var exceptions = await act.ShouldThrowAsync<NotFoundException>();

            exceptions.Message.ShouldContain(ResourceMessagesException.ITEM_NOT_FOUND);
        }

        private static GetItemHistoryUseCase CreateUseCase(
            InventoryControl.Domain.Entities.User user,
            IList<InventoryControl.Domain.Entities.ItemHistory>? histories = null,
            InventoryControl.Domain.Entities.Item? item = null
            )
        {
            var historyRepository = new ItemHistoryReadOnlyRepositoryBuilder().GetHistoryByItemId(histories, item).Build();
            var itemReadRepository = new ItemReadOnlyRepositoryBuilder().GetById(user, item).Build();
            var loggedUser = LoggedUserBuilder.Build(user);
            var mapper = MapperBuilder.Build();

            return new GetItemHistoryUseCase(historyRepository, itemReadRepository, loggedUser, mapper);
        }
    }
}
