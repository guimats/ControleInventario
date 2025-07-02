using InventoryControl.Domain.Entities;
using InventoryControl.Domain.Repositories.User;
using Moq;

namespace CommonTestUtilities.Repositories
{
    public class UserReadOnlyRepositoryBuilder
    {
        private readonly Mock<IUserReadOnlyRepository> _repository;

        public UserReadOnlyRepositoryBuilder() => _repository = new Mock<IUserReadOnlyRepository>();

        // criando regra para configurar o email (para teste de caso de usuário já registrado)
        public void ExistActiveUserWithEmail(string email)
        {
            _repository.Setup(repository => repository.ExistActiveUserWithEmail(email)).ReturnsAsync(true);
        }

        public UserReadOnlyRepositoryBuilder GetByEmailAndPassword(User user)
        {
            _repository.Setup(repository => repository.GetUserByEmailAndPassword(user.Email, user.Password)).ReturnsAsync(user);
            return this;
        }

        public IUserReadOnlyRepository Build() => _repository.Object;
    }
}
