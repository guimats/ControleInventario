using InventoryControl.Domain.Enums;

namespace InventoryControl.Domain.Dtos;

public class FilterUsersDto
{
    public string? Name { get; init; } = string.Empty;
    public string? Email { get; init; } = string.Empty;
    public Roles? Role { get; init; }
}
