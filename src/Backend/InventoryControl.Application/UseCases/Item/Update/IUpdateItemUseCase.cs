using InventoryControl.Communication.Requests;

namespace InventoryControl.Application.UseCases.Item.Update
{
    public interface IUpdateItemUseCase
    {
        public Task Execute(long id, RequestRegisterItemJson request);
    }
}
