using AutoMapper;
using InventoryControl.Application.Services.AutoMapper;

namespace CommonTestUtilities.Mapper
{
    public class MapperBuilder
    {
        public static IMapper Build()
        {
            return new MapperConfiguration(option =>
            {
                option.AddProfile(new AutoMapping());
            }).CreateMapper();
        }
    }
}
