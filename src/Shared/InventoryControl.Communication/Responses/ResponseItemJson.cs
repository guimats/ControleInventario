using InventoryControl.Communication.Enums;

namespace InventoryControl.Communication.Responses
{
    public class ResponseItemJson
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Brand { get; set; } = string.Empty;
        public string? Employee { get; set; } = string.Empty;
        public string InternalCode { get; set; } = string.Empty;
        public Department? Department { get; set; }
        public ProductType? ProductType { get; set; }
        public ItemStatus? ItemStatus { get; set; }
    }
}
