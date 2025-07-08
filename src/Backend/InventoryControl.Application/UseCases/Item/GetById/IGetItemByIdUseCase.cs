using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.UseCases.Item.GetById
{
    public interface IGetItemByIdUseCase
    {
        public Task<ResponseItemJson> Execute(long itemId);
    }
}
