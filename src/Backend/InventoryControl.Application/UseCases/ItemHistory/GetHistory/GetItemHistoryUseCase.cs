using AutoMapper;
using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Domain.Repositories.ItemHistory;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.ItemHistory.GetHistory
{
    public class GetItemHistoryUseCase : IGetItemHistoryUseCase
    {
        private readonly IItemHistoryReadOnlyRepository _historyRepository;
        private readonly IItemReadOnlyRepository _itemRepository;
        private readonly ILoggedUser _loggedUser;
        private readonly IMapper _mapper;

        public GetItemHistoryUseCase(
            IItemHistoryReadOnlyRepository historyRepository,
            IItemReadOnlyRepository itemRepository,
            ILoggedUser loggedUser,
            IMapper mapper)
        {
            _historyRepository = historyRepository;
            _itemRepository = itemRepository;
            _loggedUser = loggedUser;
            _mapper = mapper;
        }

        public async Task<ResponseItemHistoriesJson> Execute(long id)
        {
            var user = await _loggedUser.User();

            var item = await _itemRepository.GetById(user, id);

            if (item is null)
                throw new NotFoundException(ResourceMessagesException.ITEM_NOT_FOUND);

            var history = await _historyRepository.GetHistoryByItemId(item.Id);

            return new ResponseItemHistoriesJson
            {
                Histories = _mapper.Map<IList<ResponseItemHistoryJson>>(history)
            };
        }
    }
}
