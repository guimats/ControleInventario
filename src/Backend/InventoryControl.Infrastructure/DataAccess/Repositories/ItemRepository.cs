using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.Item;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Infrastructure.DataAccess.Repositories
{
    public class ItemRepository : IItemWriteOnlyRepository, IItemUpdateOnlyRepository
    {

        private readonly InventoryControlDbContext _dbContext;

        public ItemRepository(InventoryControlDbContext dbContext) => _dbContext = dbContext;

        public async Task Add(Item item) => await _dbContext.Itens.AddAsync(item);

        public async Task<Item> GetById(long id) => await _dbContext.Itens.FirstAsync(i =>  i.Id == id);

        public void Update(Item item) => _dbContext.Itens.Update(item);
    }
}
