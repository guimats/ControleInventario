using InventoryControl.Domain.Dtos;
using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Extensions;
using InventoryControl.Domain.Repositories.Item;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Infrastructure.DataAccess.Repositories
{
    public sealed class ItemRepository : IItemWriteOnlyRepository, IItemUpdateOnlyRepository, IItemReadOnlyRepository
    {

        private readonly InventoryControlDbContext _dbContext;

        public ItemRepository(InventoryControlDbContext dbContext) => _dbContext = dbContext;

        public async Task Add(Item item) => await _dbContext.Itens.AddAsync(item);

        public async Task<IList<Item>> Filter(User user, FilterItensDto filters)
        {
            var query = _dbContext
                .Itens
                .AsNoTracking()
                .Where(item => item.Active && item.UserId == user.Id);

            if (filters.Departments.Any())
            {
                query = query.Where(item => item.Department.HasValue && filters.Departments.Contains(item.Department.Value));
            }

            if (filters.ProductTypes.Any())
            {
                query = query.Where(item => item.ProductType.HasValue && filters.ProductTypes.Contains(item.ProductType.Value));
            }

            if (filters.ItemName.NotEmpty())
            {
                query = query.Where(item => item.Name.Contains(filters.ItemName));
            }

            if (filters.InternalCode.NotEmpty())
            {
                query = query.Where(item => item.InternalCode.Equals(filters.InternalCode));
            }

            if (filters.ItemStatus.HasValue)
            {
                query = query.Where(item => item.ItemStatus.Equals(filters.ItemStatus));
            }

            return await query.ToListAsync();
        }

        async Task<Item?> IItemUpdateOnlyRepository.GetById(User user, long itemId)
        {
            return await _dbContext
                .Itens
                .FirstOrDefaultAsync(item => item.UserId == user.Id && item.Id == itemId);
        }

        async Task<Item?> IItemReadOnlyRepository.GetById(User user, long itemId)
        {
            return await _dbContext
                .Itens
                .AsNoTracking()
                .FirstOrDefaultAsync(item => item.UserId == user.Id && item.Id == itemId);
        }

        public void Update(Item item) => _dbContext.Itens.Update(item);

        public async Task Delete(long itemId)
        {
            var item = await _dbContext.Itens.FindAsync(itemId);

            _dbContext.Itens.Remove(item!);
        }
    }
}
