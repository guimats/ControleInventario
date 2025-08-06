using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Interfaces.Item;

public interface IRegisterItemService
{
    public Task<ResponseRegisteredItemJson?> RegisterAsync(RequestItemJson request);
}
