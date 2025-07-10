namespace InventoryControl.Domain.Repositories.ItemHistory
{
    public interface IItemHistoryReadOnlyRepository
    {
        Task<IList<Entities.ItemHistory>> GetHistoryByItemId(long id);
    }
}
