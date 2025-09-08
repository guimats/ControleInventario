using InventoryControl.Application.UseCases.CommonValidators.ChangePassword;
using InventoryControl.Communication.Requests;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.User;
using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.Admin.ChangeUserPassword;

public class ChangeUserPasswordUseCase : IChangeUserPasswordUseCase
{
    private readonly IUserUpdateOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordEncripter _passwordEncripter;

    public ChangeUserPasswordUseCase(IUserUpdateOnlyRepository repository,
        IUnitOfWork unitOfWork,
        IPasswordEncripter passwordEncripter)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _passwordEncripter = passwordEncripter;
    }

    public async Task Execute(RequestChangePasswordJson request, long id)
    {
        var user = await _repository.GetById(id);

        Validate(request, user, _passwordEncripter);

        user.Password = _passwordEncripter.Encrypt(request.NewPassword);

        _repository.Update(user);

        await _unitOfWork.Commit();
    }

    private static void Validate(RequestChangePasswordJson request, Domain.Entities.User user, IPasswordEncripter passwordEncripter)
    {
        var validator = new ChangePasswordValidator();

        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage).Distinct().ToList();

            throw new ErrorOnValidationException(errorMessages);
        }
    }
}
