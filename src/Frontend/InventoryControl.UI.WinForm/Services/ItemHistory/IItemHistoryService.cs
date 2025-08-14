using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.ItemHistory;

public interface IItemHistoryService
{
    public Task<ResponseItemHistoriesJson?> GetItemHistoryAsync(long id);
}
