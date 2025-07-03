﻿using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Mapper;
using InventoryControl.Application.UseCases.User.Profile;
using Shouldly;

namespace UseCases.Test.User.Update
{
    public class GetUserProfileUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var _) = UserBuilder.Build();

            var useCase = CreateUseCase(user);

            var result = await useCase.Execute();

            result.ShouldNotBeNull();
            result.Name.ShouldBe(user.Name);
            result.Email.ShouldBe(user.Email);
        }

        private static GetUserProfileUseCase CreateUseCase(InventoryControl.Domain.Entities.User user)
        {
            var mapper = MapperBuilder.Build();
            var loggedUser = LoggedUserBuilder.Build(user);

            return new GetUserProfileUseCase(loggedUser, mapper);
        }
    }
}
