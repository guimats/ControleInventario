using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.ItemHistory;
using Moq;

namespace CommonTestUtilities.Repositories
{
    public class ItemHistoryReadOnlyRepositoryBuilder
    {
        private readonly Mock<IItemHistoryReadOnlyRepository> _repository;

        public ItemHistoryReadOnlyRepositoryBuilder() => _repository = new Mock<IItemHistoryReadOnlyRepository>();

        public ItemHistoryReadOnlyRepositoryBuilder GetHistoryByItemId(IList<ItemHistory>? histories = null, Item? item = null)
        {
            if (item is not null)
                _repository.Setup(repository => repository.GetHistoryByItemId(item.Id)).ReturnsAsync(histories!);

            return this;
        }

        public IItemHistoryReadOnlyRepository Build() => _repository.Object;
    }
}
