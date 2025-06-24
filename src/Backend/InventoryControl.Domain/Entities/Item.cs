using InventoryControl.Domain.Enums;

namespace InventoryControl.Domain.Entities
{
    public class Item : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Employee { get; set; } = string.Empty;
        public string InternalCode { get; set; } = string.Empty;
        public Department? Department { get; set; }
        public ProductType? ProductType { get; set; }
        public ItemStatus? ItemStatus { get; set; }
        public long UserId { get; set; }
    }
}
