using InventoryControl.Communication.Requests;

namespace InventoryControl.UI.WinForms.Services.Interfaces.Item;

public interface IUpdateItemService
{
    public Task UpdateAsync(RequestItemJson request, long id);
}
