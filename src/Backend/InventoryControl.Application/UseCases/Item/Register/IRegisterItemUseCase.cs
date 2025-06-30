using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.UseCases.Item.Register
{
    public interface IRegisterItemUseCase
    {
        public Task<ResponseRegisteredItemJson> Execute(RequestItemJson request);
    }
}
