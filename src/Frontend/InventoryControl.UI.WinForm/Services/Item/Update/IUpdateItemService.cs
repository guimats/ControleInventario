using InventoryControl.Communication.Requests;

namespace InventoryControl.UI.WinForms.Services.Item.Update;

public interface IUpdateItemService
{
    public Task UpdateAsync(RequestItemJson request, long id);
}
