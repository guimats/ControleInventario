namespace InventoryControl.Domain.Repositories.ItemHistory
{
    public interface IItemHistoryWriteOnlyRepository
    {
        Task Add(Entities.ItemHistory history);
    }
}
