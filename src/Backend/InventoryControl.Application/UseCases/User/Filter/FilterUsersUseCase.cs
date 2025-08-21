using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories.User;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.User.Filter;

public class FilterUsersUseCase : IFilterUsersUseCase
{
    private readonly IMapper _mapper;
    private readonly IUserReadOnlyRepository _repository;

    public FilterUsersUseCase(IMapper mapper, IUserReadOnlyRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ResponseUsersProfilesJson> Execute(RequestFilterUserJson request)
    {
        Validate(request);

        var filters = new Domain.Dtos.FilterUsersDto
        {
            Name = request.Name,
            Email = request.Email,
            Role = (Domain.Enums.Roles?)request.Role
        };

        var users = await _repository.Filter(filters);

        return new ResponseUsersProfilesJson
        {
            Users = _mapper.Map<List<ResponseUserProfileJson>>(users)
        };
    }

    private static void Validate(RequestFilterUserJson request)
    {
        var validator = new FilterUsersValidator();

        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errorsMessage = result.Errors.Select(error => error.ErrorMessage).Distinct().ToList();

            throw new ErrorOnValidationException(errorsMessage);
        }
    }
}
