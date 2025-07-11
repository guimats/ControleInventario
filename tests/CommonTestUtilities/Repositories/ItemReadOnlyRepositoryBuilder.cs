using InventoryControl.Domain.Dtos;
using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.Item;
using Moq;

namespace CommonTestUtilities.Repositories
{
    public class ItemReadOnlyRepositoryBuilder
    {
        private readonly Mock<IItemReadOnlyRepository> _repository;

        public ItemReadOnlyRepositoryBuilder() => _repository = new Mock<IItemReadOnlyRepository>();

        public ItemReadOnlyRepositoryBuilder Filter(User user, IList<Item> itens)
        {
            // It.IsAny ignora qual o valor que será recebido no parametro
            _repository.Setup(repository => repository.Filter(user, It.IsAny<FilterItensDto>())).ReturnsAsync(itens);

            return this;
        }

        public ItemReadOnlyRepositoryBuilder GetById(User user, Item? item = null)
        {
            if (item is not null)
                _repository.Setup(repository => repository.GetById(user, item.Id)).ReturnsAsync(item);

            return this;
        }

        public IItemReadOnlyRepository Build() => _repository.Object;
    }
}
