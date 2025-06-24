using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Exceptions.ExceptionsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<ResponseRegisteredItemJson> Execute(RequestRegisterItemJson request)
        {
            Validate(request);

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

        private static void Validate(RequestRegisterItemJson request)
        {
            var validator = new RegisterItemValidator();

            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                throw new ErrorOnValidationException(result.Errors.Select(e => e.ErrorMessage).Distinct().ToList());
            }
        }
    }
}
