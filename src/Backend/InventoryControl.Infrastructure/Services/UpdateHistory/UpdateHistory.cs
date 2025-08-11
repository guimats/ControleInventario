using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.ItemHistory;
using InventoryControl.Domain.Services.ItemHistory;
using InventoryControl.Infrastructure.Helpers;
using System.Text.Json;

namespace InventoryControl.Infrastructure.Services.UpdateHistory
{
    public class UpdateHistory : IItemHistoryService
    {
        private readonly IItemHistoryWriteOnlyRepository _repository;

        public UpdateHistory(IItemHistoryWriteOnlyRepository repository)
        {
            _repository = repository;
        }

        public async Task RegisterUpdateHistory(Item oldItem, Item newItem, string userName)
        {
            var history = new ItemHistory
            {
                ItemId = newItem.Id,
                Action = "Update",
                UserName = userName,
                OldData = JsonHelper.Serialize(oldItem),
                NewData = JsonHelper.Serialize(newItem)
            };

            await _repository.Add(history);
        }
    }
}
