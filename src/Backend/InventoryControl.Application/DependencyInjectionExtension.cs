using InventoryControl.Application.Services;
using InventoryControl.Application.UseCases.Item.Register;
using InventoryControl.Application.UseCases.Login.DoLogin;
using InventoryControl.Application.UseCases.User.ChangePassword;
using InventoryControl.Application.UseCases.User.Profile;
using InventoryControl.Application.UseCases.User.Register;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryControl.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddScoped(option => new AutoMapper.MapperConfiguration(options =>
            {
                options.AddProfile(new AutoMapping());
            }).CreateMapper());
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegisterUserUseCase, RegisterUserUseCase>();
            services.AddScoped<IGetUserProfileUseCase, GetUserProfileUseCase>();
            services.AddScoped<IDoLoginUseCase, DoLoginUseCase>();
            services.AddScoped<IRegisterItemUseCase, RegisterItemUseCase>();
            services.AddScoped<IChangePasswordUseCase, ChangePasswordUseCase>();
        }
    }
}
