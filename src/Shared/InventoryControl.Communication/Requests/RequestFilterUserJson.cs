using InventoryControl.Communication.Enums;

namespace InventoryControl.Communication.Requests;

public class RequestFilterUserJson
{
    public string? Name { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public Roles? Role { get; set; } 
}
