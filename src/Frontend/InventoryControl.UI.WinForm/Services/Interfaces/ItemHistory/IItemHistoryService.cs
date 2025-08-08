using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Interfaces.ItemHistory;

public interface IItemHistoryService
{
    public Task<ResponseItemHistoriesJson?> GetItemHistoryAsync(long id);
}
