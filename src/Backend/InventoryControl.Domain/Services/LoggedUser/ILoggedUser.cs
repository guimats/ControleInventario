using InventoryControl.Domain.Entities;

namespace InventoryControl.Domain.Services.LoggedUser
{
    public interface ILoggedUser
    {
        public Task<User> User();
    }
}
