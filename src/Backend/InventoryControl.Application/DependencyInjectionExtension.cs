using InventoryControl.Application.Services.AutoMapper;
using InventoryControl.Application.UseCases.Admin.ChangeUserPassword;
using InventoryControl.Application.UseCases.Item.Delete;
using InventoryControl.Application.UseCases.Item.Filter;
using InventoryControl.Application.UseCases.Item.GetById;
using InventoryControl.Application.UseCases.Item.Register;
using InventoryControl.Application.UseCases.Item.Update;
using InventoryControl.Application.UseCases.ItemHistory.GetHistory;
using InventoryControl.Application.UseCases.Login.DoLogin;
using InventoryControl.Application.UseCases.Token.RefreshToken;
using InventoryControl.Application.UseCases.User.ChangePassword;
using InventoryControl.Application.UseCases.User.Filter;
using InventoryControl.Application.UseCases.User.Profile;
using InventoryControl.Application.UseCases.User.Register;
using InventoryControl.Application.UseCases.User.Update;
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
            // USER
            services.AddScoped<IRegisterUserUseCase, RegisterUserUseCase>();
            services.AddScoped<IGetUserProfileUseCase, GetUserProfileUseCase>();
            services.AddScoped<IFilterUsersUseCase, FilterUsersUseCase>();
            services.AddScoped<IUpdateUserUseCase, UpdateUserUseCase>();
            services.AddScoped<IChangePasswordUseCase, ChangePasswordUseCase>();

            // ADMIN
            services.AddScoped<IChangeUserPasswordUseCase, ChangeUserPasswordUseCase>();

            // ITEM
            services.AddScoped<IRegisterItemUseCase, RegisterItemUseCase>();
            services.AddScoped<IUpdateItemUseCase, UpdateItemUseCase>();
            services.AddScoped<IFilterItensUseCase, FilterItensUseCase>();
            services.AddScoped<IGetItemByIdUseCase, GetItemByIdUseCase>();
            services.AddScoped<IDeleteItemUseCase, DeleteItemUseCase>();
            services.AddScoped<IGetItemHistoryUseCase, GetItemHistoryUseCase>();

            // GENERAL
            services.AddScoped<IDoLoginUseCase, DoLoginUseCase>();
            services.AddScoped<IUseRefreshTokenUseCase, UseRefreshTokenUseCase>();
        }
    }
}
