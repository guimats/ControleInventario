namespace InventoryControl.UI.WinForms.Services.Interfaces.Item;

public interface IDeleteItemService
{
    public Task DeleteItemAsync(long id);
}
