using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Domain.Services.LoggedUser;

namespace InventoryControl.Application.UseCases.Item.Register
{
    public class RegisterItemUseCase : IRegisterItemUseCase
    {
        private readonly IItemWriteOnlyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggedUser _loogedUser;
        private readonly IMapper _mapper;

        public RegisterItemUseCase(IItemWriteOnlyRepository repository, IUnitOfWork unitOfWork, ILoggedUser loogedUser, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _loogedUser = loogedUser;
            _mapper = mapper;
        }

        public async Task<ResponseRegisteredItemJson> Execute(RequestItemJson request)
        {
            ItemValidatorBase.Validate(request);

            var loggedUser = await _loogedUser.User();

            var item = _mapper.Map<Domain.Entities.Item>(request);
            item.UserId = loggedUser.Id;

            await _repository.Add(item);

            await _unitOfWork.Commit();

            return new ResponseRegisteredItemJson
            {
                Name = item.Name
            };
        }
    }
}
