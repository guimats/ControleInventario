using InventoryControl.Communication.Requests;

namespace InventoryControl.Application.UseCases.Admin.ChangeUserPassword
{
    public interface IChangeUserPasswordUseCase
    {
        public Task Execute(RequestChangePasswordJson request, long id);
    }

}
