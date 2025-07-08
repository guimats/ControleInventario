
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.Item.Delete
{
    public class DeleteItemUseCase : IDeleteItemUseCase
    {
        private readonly IItemWriteOnlyRepository _writeRepository;
        private readonly IItemReadOnlyRepository _readRepository;
        private readonly ILoggedUser _loggedUser;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteItemUseCase(
            IItemWriteOnlyRepository writeRepository,
            IItemReadOnlyRepository readRepository,
            ILoggedUser loggedUser,
            IUnitOfWork unitOfWork)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
            _loggedUser = loggedUser;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(long itemId)
        {
            var loggedUser = await _loggedUser.User();

            var item = await _readRepository.GetById(loggedUser, itemId);

            if (item is null)
                throw new NotFoundException(ResourceMessagesException.ITEM_NOT_FOUND);

            await _writeRepository.Delete(itemId);

            await _unitOfWork.Commit();
        }
    }
}
