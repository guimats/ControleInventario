using InventoryControl.Communication.Enums;

namespace InventoryControl.Communication.Responses
{
    public class ResponseUserProfileJson
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Roles? Role { get; set; }
    }
}
