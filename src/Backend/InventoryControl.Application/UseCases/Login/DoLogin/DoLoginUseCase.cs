using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories.User;
using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Domain.Security.Tokens;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.Login.DoLogin
{
    public class DoLoginUseCase : IDoLoginUseCase
    {
        private readonly IUserReadOnlyRepository _repository;
        private readonly IPasswordEncripter _passwordEncripter;
        private readonly IAccessTokenGenerator _accessTokenGenerator;

        public DoLoginUseCase(IUserReadOnlyRepository repository, IPasswordEncripter passwordEncripter, IAccessTokenGenerator accessTokenGenerator)
        {
            _repository = repository;
            _passwordEncripter = passwordEncripter;
            _accessTokenGenerator = accessTokenGenerator;
        }

        public async Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request)
        {
            var encriptedPassword = _passwordEncripter.Encrypt(request.Password);

            var user = await _repository.GetUserByEmailAndPassword(request.Email, encriptedPassword) ?? throw new InvalidLoginException();

            return new ResponseRegisteredUserJson
            {
                Name = user.Name,
                Tokens = new ResponseTokenJson { AccessToken = _accessTokenGenerator.Generate(user.UserIdentifier) }
            };
        }
    }
}
