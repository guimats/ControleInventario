using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.Services
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToDomain();
            DomainToResponse();
        }

        public void RequestToDomain()
        {
            CreateMap<RequestRegisterUserJson, Domain.Entities.User>()
                .ForMember(dest => dest.Password, opt => opt.Ignore());
            CreateMap<RequestRegisterItemJson, Domain.Entities.Item>();
        }

        public void DomainToResponse()
        {
            CreateMap<Domain.Entities.User, ResponseUserProfileJson>();
        }
    }
}
