using InventoryControl.Communication.Requests;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.User;
using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.User.ChangePassword
{
    public class ChangePasswordUseCase : IChangePasswordUseCase
    {
        private readonly IUserUpdateOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordEncripter _passwordEncripter;
        private readonly ILoggedUser _loggedUser;

        public ChangePasswordUseCase(
            IUserUpdateOnlyRepository repository, 
            IUnitOfWork unitOfWork, 
            IPasswordEncripter passwordEncripter, 
            ILoggedUser loggedUser)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _passwordEncripter = passwordEncripter;
            _loggedUser = loggedUser;
        }

        public async Task Execute(RequestChangePasswordJson request)
        {
            var loggedUser = await _loggedUser.User();

            Validate(request, loggedUser);
            
            var user = await _repository.GetById(loggedUser.Id);

            user.Password = _passwordEncripter.Encrypt(request.NewPassword);

            _repository.Update(user);

            await _unitOfWork.Commit();
        }

        private void Validate(RequestChangePasswordJson request, Domain.Entities.User loggedUser)
        {
            var validator = new ChangePasswordValidator();

            var result = validator.Validate(request);

            var currentPasswordEncipted = _passwordEncripter.Encrypt(request.Password);

            if (!currentPasswordEncipted.Equals(loggedUser.Password))
            {
                result.Errors.Add(new FluentValidation.Results.ValidationFailure(
                    string.Empty, ResourceMessagesException.PASSWORD_DIFFERENT_CURRENT_PASSWORD));
            }

            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage).Distinct().ToList();

                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
