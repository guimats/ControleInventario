using InventoryControl.Domain.Enums;

namespace InventoryControl.Domain.Dtos
{
    public record FilterItensDto
    {
        public string? ItemName { get; init; }
        public string? InternalCode { get; init; }
        public IList<Department> Departments { get; init; } = [];
        public IList<ProductType> ProductTypes { get; init; } = [];
        public ItemStatus? ItemStatus { get; init; }
    }
}
