using InventoryControl.Domain.Repositories.Item;
using Moq;

namespace CommonTestUtilities.Repositories
{
    public class ItemWriteOnlyRepositoryBuilder
    {
        public static IItemWriteOnlyRepository Build()
        {
            var mock = new Mock<IItemWriteOnlyRepository>();

            return mock.Object;
        }
    }
}
