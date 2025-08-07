using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.UI.WinForms.Services.Interfaces.Item;

public interface IFilterItensService
{
    public Task<ResponseItensJson?> FilterItensAsync(RequestFilterItemJson request);
}
