using AutoMapper;
using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.Exceptions;

namespace InventoryControl.Application.UseCases.Item.GetById
{
    public class GetItemByIdUseCase : IGetItemByIdUseCase
    {
        private readonly IItemReadOnlyRepository _repository;
        private readonly ILoggedUser _loggedUser;
        private readonly IMapper _mapper;

        public GetItemByIdUseCase(
            IItemReadOnlyRepository repository,
            ILoggedUser loggedUser,
            IMapper mapper)
        {
            _repository = repository;
            _loggedUser = loggedUser;
            _mapper = mapper;
        }

        public async Task<ResponseItemJson> Execute(long itemId)
        {
            var loggedUser = await _loggedUser.User();

            var item = await _repository.GetById(loggedUser, itemId);

            if (item is null)
                throw new NotFoundException(ResourceMessagesException.ITEM_NOT_FOUND);

            return _mapper.Map<ResponseItemJson>(item);
        }
    }
}
