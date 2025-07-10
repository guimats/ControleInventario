using System.Text.Json.Serialization;
using System.Text.Json;

namespace InventoryControl.Infrastructure.Helpers
{
    public class JsonHelper
    {
        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions
            {
                WriteIndented = false,
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }
    }
}
