using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.ItemHistory;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Infrastructure.DataAccess.Repositories
{
    public class ItemHistoryRepository : IItemHistoryWriteOnlyRepository, IItemHistoryReadOnlyRepository
    {
        private readonly InventoryControlDbContext _dbContext;

        public ItemHistoryRepository(InventoryControlDbContext dbContext) => _dbContext = dbContext;

        public async Task Add(ItemHistory history) => await _dbContext.ItemHistories.AddAsync(history);

        public async Task<IList<ItemHistory>> GetHistoryByItemId(long id)
        {
            return await _dbContext
                .ItemHistories
                .AsNoTracking()
                .Where(history => history.ItemId == id)
                .OrderByDescending(h => h.CreatedOn)
                .ToListAsync();
        }
    }
}
