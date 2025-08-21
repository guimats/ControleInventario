using InventoryControl.Domain.Dtos;
using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Extensions;
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

        public async Task<IList<User>> Filter(FilterUsersDto filters)
        {
            var query = _dbContext.Users.AsNoTracking().Where(user => user.Active);

            if (filters.Name.NotEmpty())
                query = query.Where(user => user.Name.Equals(filters.Name));

            if (filters.Email.NotEmpty())
                query = query.Where(user => user.Email.Equals(filters.Email));

            if (filters.Role.HasValue)
                query = query.Where(user => user.Role.Equals(filters.Role));

            return await query.ToListAsync();
        }
    }
}
