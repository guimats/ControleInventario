namespace InventoryControl.Domain.Repositories.Item
{
    public interface IItemUpdateOnlyRepository
    {
        public Task<Entities.Item?> GetById(Entities.User user, long itemId);

        public void Update(Entities.Item item);
    }
}
