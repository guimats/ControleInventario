using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Item.Write;

public interface IWriteItemService
{
    public Task<ResponseRegisteredItemJson?> RegisterAsync(RequestItemJson request);

    public Task DeleteItemAsync(long id);
}
