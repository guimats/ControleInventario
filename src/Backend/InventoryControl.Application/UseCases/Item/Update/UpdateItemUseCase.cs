using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.Item.Update
{
    public class UpdateItemUseCase : IUpdateItemUseCase
    {
        private readonly IItemUpdateOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateItemUseCase(
            IItemUpdateOnlyRepository repository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Execute(long id, RequestItemJson request)
        {
            ItemValidatorBase.Validate(request);

            var item = await _repository.GetById(id);

            if (item is null)
                throw new NotFoundException(ResourceMessagesException.ITEM_NOT_FOUND);

            _mapper.Map(request, item);

            _repository.Update(item);

            await _unitOfWork.Commit();
        }
    }
}
