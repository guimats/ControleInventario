using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.UseCases.Item.Filter
{
    public interface IFilterItensUseCase
    {
        public Task<ResponseItensJson> Execute(RequestFilterItemJson request);
    }
}
