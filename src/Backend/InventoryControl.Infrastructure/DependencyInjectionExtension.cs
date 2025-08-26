using FluentMigrator.Runner;
using InventoryControl.Domain.Repositories;
using InventoryControl.Domain.Repositories.Item;
using InventoryControl.Domain.Repositories.ItemHistory;
using InventoryControl.Domain.Repositories.Token;
using InventoryControl.Domain.Repositories.User;
using InventoryControl.Domain.Security.Cryptography;
using InventoryControl.Domain.Security.Tokens;
using InventoryControl.Domain.Services.ItemHistory;
using InventoryControl.Domain.Services.LoggedUser;
using InventoryControl.Infrastructure.DataAccess;
using InventoryControl.Infrastructure.DataAccess.Repositories;
using InventoryControl.Infrastructure.Extensions;
using InventoryControl.Infrastructure.Security.Tokens.Access.Generator;
using InventoryControl.Infrastructure.Security.Tokens.Access.Validator;
using InventoryControl.Infrastructure.Security.Tokens.Refresh;
using InventoryControl.Infrastructure.Services.Cryptography;
using InventoryControl.Infrastructure.Services.LoggedUser;
using InventoryControl.Infrastructure.Services.UpdateHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace InventoryControl.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddPasswordsEncripter(services, configuration);
            AddRepositories(services);
            AddLoggedUser(services);
            AddUpdateHistory(services);
            AddTokens(services, configuration);

            //validando se está em ambiente de teste
            if (configuration.IsUnitTestEnviroment())
                return;

            AddDbContext(services, configuration);
            AddFluentMigrator(services, configuration);
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.ConnectionString();
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 42));

            services.AddDbContext<InventoryControlDbContext>(dbContextOptions =>
            {
                dbContextOptions.UseMySql(connectionString, serverVersion);
            });
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserReadOnlyRepository, UserRepository>();
            services.AddScoped<IUserWriteOnlyRepository, UserRepository>();
            services.AddScoped<IUserUpdateOnlyRepository, UserRepository>();
            services.AddScoped<IItemWriteOnlyRepository, ItemRepository>();
            services.AddScoped<IItemUpdateOnlyRepository, ItemRepository>();
            services.AddScoped<IItemReadOnlyRepository, ItemRepository>();
            services.AddScoped<IItemHistoryWriteOnlyRepository, ItemHistoryRepository>();
            services.AddScoped<IItemHistoryReadOnlyRepository, ItemHistoryRepository>();
            services.AddScoped<ITokenRepository, TokenRepository>();
        }

        private static void AddFluentMigrator(IServiceCollection services, IConfiguration configuration)
        {
            services.AddFluentMigratorCore().ConfigureRunner(options =>
            {
                var connectionString = configuration.ConnectionString();

                options
                .AddMySql5()
                .WithGlobalConnectionString(connectionString)
                .ScanIn(Assembly.Load("InventoryControl.Infrastructure")).For.All();
            });
        }

        private static void AddTokens(IServiceCollection services, IConfiguration configuration)
        {
            var expirationTimeMinutes = configuration.GetValue<uint>("Settings:Jwt:ExpirationTime");
            var signingKey = configuration.GetValue<string>("Settings:Jwt:SigningKey");

            services.AddScoped<IAccessTokenGenerator>(options => new JwtTokenGenerator(expirationTimeMinutes, signingKey!));
            services.AddScoped<IAccessTokenValidator>(options => new JwtTokenValidator(signingKey!));
            services.AddScoped<IRefreshTokenGenerator, RefreshTokenGenerator>();
        }

        private static void AddLoggedUser(IServiceCollection services) => services.AddScoped<ILoggedUser, LoggedUser>();

        private static void AddPasswordsEncripter(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPasswordEncripter>(options => new BCryptNet());
        }

        private static void AddUpdateHistory(IServiceCollection services) => services.AddScoped<IItemHistoryService, UpdateHistory>();
    }
}