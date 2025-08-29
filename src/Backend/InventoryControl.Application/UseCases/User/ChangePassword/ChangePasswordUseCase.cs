using InventoryControl.Application.UseCases.CommonValidators.ChangePassword;
using InventoryControl.Communication.Requests;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.User;
using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Domain.Services.LoggedUser;

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

            ChangePasswordValidateHelper.Validate(request, loggedUser, _passwordEncripter);
            
            var user = await _repository.GetById(loggedUser.Id);

            user.Password = _passwordEncripter.Encrypt(request.NewPassword);

            _repository.Update(user);

            await _unitOfWork.Commit();
        }
    }
}
