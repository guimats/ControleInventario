using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Security.Tokens;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace InventoryControl.Infrastructure.Services.LoggedUser
{
    public class LoggedUser : ILoggedUser
    {
        private readonly InventoryControlDbContext _dbContext;
        private readonly ITokenProvider _tokenProvider;

        public LoggedUser(InventoryControlDbContext dbContext) => _dbContext = dbContext;

        public async Task<User> User()
        {
            var token = _tokenProvider.Value();

            var tokenHandler = new JwtSecurityTokenHandler();

            var jetSecurityToken = tokenHandler.ReadJwtToken(token);

            var identifier = jetSecurityToken.Claims.First(c => c.Type == ClaimTypes.Sid).Value;

            var userIdentifier = Guid.Parse(identifier);

            return await _dbContext.Users.AsNoTracking().FirstAsync(user => user.Active && user.UserIdentifier == userIdentifier);
        }
    }
}
