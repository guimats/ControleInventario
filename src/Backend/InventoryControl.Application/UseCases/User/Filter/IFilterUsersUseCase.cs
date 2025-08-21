using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.UseCases.User.Filter;

public interface IFilterUsersUseCase
{
    public Task<ResponseUsersProfilesJson> Execute(RequestFilterUserJson request);
}
