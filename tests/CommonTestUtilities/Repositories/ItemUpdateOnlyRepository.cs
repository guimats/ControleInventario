using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.Item;
using Moq;

namespace CommonTestUtilities.Repositories
{
    public class ItemUpdateOnlyRepository
    {
        private readonly Mock<IItemUpdateOnlyRepository> _repository;

        public ItemUpdateOnlyRepository() => _repository = new Mock<IItemUpdateOnlyRepository>();

        public ItemUpdateOnlyRepository GetById(User user, Item item)
        {
            if (item.Id != 0)
                _repository.Setup(i => i.GetById(user, item.Id)).ReturnsAsync(item);
            return this;
        }

        public IItemUpdateOnlyRepository Build()
        {
            return _repository.Object;
        }
    }
}
