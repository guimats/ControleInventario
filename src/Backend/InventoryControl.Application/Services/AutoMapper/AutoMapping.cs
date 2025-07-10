using AutoMapper;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;

namespace InventoryControl.Application.Services.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToDomain();
            DomainToResponse();
            DomainToDomain();
        }

        public void RequestToDomain()
        {
            CreateMap<RequestRegisterUserJson, Domain.Entities.User>()
                .ForMember(dest => dest.Password, opt => opt.Ignore());
            CreateMap<RequestItemJson, Domain.Entities.Item>();
        }

        public void DomainToResponse()
        {
            CreateMap<Domain.Entities.User, ResponseUserProfileJson>();

            CreateMap<Domain.Entities.Item, ResponseItemJson>();

            CreateMap<Domain.Entities.ItemHistory, ResponseItemHistoryJson>();
        }

        public void DomainToDomain()
        {
            CreateMap<Domain.Entities.Item, Domain.Entities.Item>();
        }
    }
}
