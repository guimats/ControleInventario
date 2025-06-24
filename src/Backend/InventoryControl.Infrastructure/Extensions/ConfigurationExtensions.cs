using Microsoft.Extensions.Configuration;

namespace InventoryControl.Infrastructure.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string ConnectionString(this IConfiguration configuration) => configuration.GetConnectionString("Connection")!;
    }
}
