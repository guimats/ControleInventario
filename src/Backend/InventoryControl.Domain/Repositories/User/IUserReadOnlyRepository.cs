﻿namespace InventoryControl.Domain.Repositories.User
{
    public interface IUserReadOnlyRepository
    {
        public Task<bool> ExistActiveUserWithEmail (string email);

        public Task<bool> ExistActiveUserWithIdentifier(Guid userIdentifier);

        public Task<Entities.User?> GetUserByEmailAndPassword (string email, string password);
    }
}
