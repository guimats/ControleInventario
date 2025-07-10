namespace InventoryControl.Domain.Services.ItemHistory
{
    public interface IItemHistoryService
    {
        Task RegisterUpdateHistory(Entities.Item oldItem, Entities.Item newItem, string userName);
    }
}
