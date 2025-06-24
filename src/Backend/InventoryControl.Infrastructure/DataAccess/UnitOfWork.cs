using InventoryControl.Domain.Repositories;

namespace InventoryControl.Infrastructure.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InventoryControlDbContext _dbContext;

        public UnitOfWork(InventoryControlDbContext dbContext) => _dbContext = dbContext;

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
