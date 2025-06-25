using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.Item;

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

        public async Task Execute(long id, RequestRegisterItemJson request)
        {
            ItemValidatorBase.Validate(request);

            var item = await _repository.GetById(id);

            _mapper.Map(request, item);

            _repository.Update(item);

            await _unitOfWork.Commit();
        }
    }
}
