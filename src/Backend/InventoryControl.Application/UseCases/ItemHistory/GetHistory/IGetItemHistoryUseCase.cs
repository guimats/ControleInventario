using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.UseCases.ItemHistory.GetHistory
{
    public interface IGetItemHistoryUseCase
    {
        public Task<ResponseItemHistoriesJson> Execute(long id);
    }
}
