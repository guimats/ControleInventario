﻿namespace InventoryControl.Domain.Repositories
{
    public interface IUnitOfWork
    {
        public Task Commit();
    }
}
