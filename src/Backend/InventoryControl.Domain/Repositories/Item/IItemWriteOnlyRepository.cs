namespace InventoryControl.Domain.Repositories.Item
{
    public interface IItemWriteOnlyRepository
    {
        public Task Add(Entities.Item item);

        public Task Delete(long itemId);
    }
}
