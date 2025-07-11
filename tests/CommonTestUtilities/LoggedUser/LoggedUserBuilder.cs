﻿using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Services.LoggedUser;
using Moq;

namespace CommonTestUtilities.LoggedUser
{
    public class LoggedUserBuilder
    {
        public static ILoggedUser Build(User user)
        {
            var mock = new Mock<ILoggedUser>();
            mock.Setup(x => x.User()).ReturnsAsync(user);

            return mock.Object;
        }
    }
}
