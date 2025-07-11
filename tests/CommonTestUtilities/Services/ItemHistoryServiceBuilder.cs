using InventoryControl.Domain.Services.ItemHistory;
using Moq;

namespace CommonTestUtilities.Services
{
    public class ItemHistoryServiceBuilder
    {
        public static IItemHistoryService Build()
        {
            var mock = new Mock<IItemHistoryService>();

            return mock.Object;
        }
    }
}
