using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Exceptions.ExceptionsBase;

namespace InventoryControl.Application.UseCases.Item.Filter
{
    public class FilterItensUseCase : IFilterItensUseCase
    {
        private readonly IMapper _mapper;
        private readonly ILoggedUser _loggedUser;
        private readonly IItemReadOnlyRepository _repository;

        public FilterItensUseCase(IMapper mapper, ILoggedUser loggedUser, IItemReadOnlyRepository repository)
        {
            _mapper = mapper;
            _loggedUser = loggedUser;
            _repository = repository;
        }

        public async Task<ResponseItensJson> Execute(RequestFilterItemJson request)
        {
            Validate(request);

            var loggedUser = await _loggedUser.User();

            var filters = new Domain.Dtos.FilterItensDto 
            {
                ItemName = request.ItemName,
                InternalCode = request.InternalCode,
                Departments = request.Departments.Distinct().Select(c => (Domain.Enums.Department)c).ToList(),
                ProductTypes = request.ProductTypes.Distinct().Select(c => (Domain.Enums.ProductType)c).ToList(),
                ItemStatus = (Domain.Enums.ItemStatus?)request.ItemStatus
            };

            var recipes = await _repository.Filter(loggedUser, filters);

            return new ResponseItensJson
            {
                Itens = _mapper.Map<List<ResponseItemJson>>(recipes)
            };

        }

        private static void Validate(RequestFilterItemJson request)
        {
            var validator = new FilterItensValidator();

            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(error => error.ErrorMessage).Distinct().ToList();

                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
