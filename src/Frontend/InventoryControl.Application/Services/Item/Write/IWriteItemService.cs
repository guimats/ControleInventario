using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Interfaces.Item;

public interface IWriteItemService
{
    public Task<ResponseRegisteredItemJson?> RegisterAsync(RequestItemJson request);

    public Task<bool> DeleteItemAsync(long id);
}
