using CommonTestUtilities.Entities;
using CommonTestUtilities.LoggedUser;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using InventoryControl.Application.UseCases.Item.Filter;
using InventoryControl.Communication.Enums;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using Shouldly;

namespace UseCases.Test.Item.Filter
{
    public class FilterItensUseCaseTest
    {
        [Fact]
        public async Task Success()
        {
            (var user, var _) = UserBuilder.Build();

            var request = RequestFilterItemJsonBuilder.Build();

            var itens = ItemBuilder.Collection(user);

            var useCase = CreateUseCase(user, itens);

            var result = await useCase.Execute(request);

            result.ShouldNotBeNull();
            result.Itens.ShouldNotBeNull();
            result.Itens.ShouldNotBeEmpty();
            result.Itens.Count.ShouldBe(itens.Count);
        }

        [Fact]
        public async Task Error_Department_Invalid()
        {
            (var user, var _) = UserBuilder.Build();

            var request = RequestFilterItemJsonBuilder.Build();
            request.Departments.Add((Department)1000);

            var itens = ItemBuilder.Collection(user);

            var useCase = CreateUseCase(user, itens);

            Func<Task> act = async () => await useCase.Execute(request);

            var execptions = await act.ShouldThrowAsync<ErrorOnValidationException>();

            execptions.GetMessages().Count.ShouldBe(1);
            execptions.GetMessages().ShouldContain(ResourceMessagesException.DEPARTMENT_NOT_SUPORTED);
        }

        private static FilterItensUseCase CreateUseCase(
            InventoryControl.Domain.Entities.User user,
            IList<InventoryControl.Domain.Entities.Item> itens)
        {
            var mapper = MapperBuilder.Build();
            var loggedUser = LoggedUserBuilder.Build(user);
            var repository = new ItemReadOnlyRepositoryBuilder().Filter(user, itens).Build();

            return new FilterItensUseCase(mapper, loggedUser, repository);
        }
    }
}
