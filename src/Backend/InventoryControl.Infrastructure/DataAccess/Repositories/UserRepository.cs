using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.User;
using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Infrastructure.DataAccess.Repositories
{
    public class UserRepository : IUserWriteOnlyRepository, IUserReadOnlyRepository, IUserUpdateOnlyRepository
    {

        private readonly InventoryControlDbContext _dbContext;

        public UserRepository(InventoryControlDbContext dbContext) => _dbContext = dbContext;

        public async Task Add(User user) => await _dbContext.Users.AddAsync(user);

        public async Task<bool> ExistActiveUserWithEmail(string email) => await _dbContext.Users.AnyAsync(user => user.Email.Equals(email) && user.Active);

        public async Task<bool> ExistActiveUserWithIdentifier(Guid userIdentifier)
        {
            return await _dbContext.Users.AnyAsync(user => user.UserIdentifier.Equals(userIdentifier) && user.Active);
        }

        public async Task<User?> GetUserByEmailAndPassword(string email, string password)
        {
            return await _dbContext.Users.AsNoTracking()
                .FirstOrDefaultAsync(user => user.Active && user.Email.Equals(email) && user.Password.Equals(password));
        }

        public async Task<User> GetById(long id) => await _dbContext.Users.FirstAsync(user => user.Id == id);

        public void Update(User user) => _dbContext.Users.Update(user);
    }
}
