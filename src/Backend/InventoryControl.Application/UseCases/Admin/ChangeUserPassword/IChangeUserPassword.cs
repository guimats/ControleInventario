using InventoryControl.Communication.Requests;

namespace InventoryControl.Application.UseCases.Admin.ChangeUserPassword
{
    public interface IChangeUserPassword
    {
        public Task Execute(RequestChangePasswordJson request, long id);
    }

}
