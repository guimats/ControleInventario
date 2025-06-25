namespace InventoryControl.Domain.Repositories.Item
{
    public interface IItemUpdateOnlyRepository
    {
        public Task<Entities.Item> GetById(long id);

        public void Update(Entities.Item item);
    }
}
