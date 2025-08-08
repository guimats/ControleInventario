using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Interfaces.Item;

public interface ISaveItemService
{
    public Task<ResponseRegisteredItemJson?> RegisterAsync(RequestItemJson request);

    public Task UpdateAsync(RequestItemJson request, long id);
}
