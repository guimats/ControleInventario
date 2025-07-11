using InventoryControl.Domain.Repositories.ItemHistory;
using Moq;

namespace CommonTestUtilities.Repositories
{
    public class ItemHistoryWriteOnlyRepositoryBuilder
    {
        public static IItemHistoryWriteOnlyRepository Build()
        {
            var mock = new Mock<IItemHistoryWriteOnlyRepository>();

            return mock.Object;
        }
    }
}
