using InventoryControl.Domain.Dtos;

namespace InventoryControl.Domain.Repositories.Item
{
    public interface IItemReadOnlyRepository
    {
        Task<IList<Entities.Item>> Filter(Entities.User user, FilterItensDto filters);

        Task<Entities.Item?> GetById(Entities.User user, long itemId);
    }
}
