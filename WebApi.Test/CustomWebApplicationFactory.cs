using CommonTestUtilities.Entities;
using InventoryControl.Domain.Enums;
using InventoryControl.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Test
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {
        private InventoryControl.Domain.Entities.Item _item = default!;
        private InventoryControl.Domain.Entities.User _user = default!;
        private string _password = string.Empty;

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Test")
                .ConfigureServices(services =>
                {
                    // varificando se tem um dbContext ativo e removendo se sim
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof
                    (DbContextOptions<InventoryControlDbContext>));
                    if (descriptor is not null)
                        services.Remove(descriptor);

                    var provider = services.AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();

                    // adicionando um novo banco de dados
                    services.AddDbContext<InventoryControlDbContext>(options =>
                    {
                        options.UseInMemoryDatabase("InMemoryDbForTesting");
                        options.UseInternalServiceProvider(provider);
                    });

                    using var scope = services.BuildServiceProvider().CreateScope();

                    var dbContext = scope.ServiceProvider.GetRequiredService<InventoryControlDbContext>();

                    dbContext.Database.EnsureDeleted();

                    StartDatabase(dbContext);
                });
        }

        public string GetEmail() => _user.Email;
        public string GetPassword() => _password;
        public string GetName() => _user.Name;
        public Guid GetUserIdentifier() => _user.UserIdentifier;

        public string GetItemName() => _item.Name;
        public string GetItemEmployee() => _item.Employee;
        public string GetItemInternalCode() => _item.InternalCode;
        public ProductType? GetItemProductType() => _item.ProductType;
        public ItemStatus? GetItemStatus() => _item.ItemStatus;

        private void StartDatabase(InventoryControlDbContext dbContext)
        {
            (_user, _password) = UserBuilder.Build();

            _item = ItemBuilder.Build(_user);

            dbContext.Users.Add(_user);
            dbContext.Itens.Add(_item);

            dbContext.SaveChanges();
        }
    }
}
