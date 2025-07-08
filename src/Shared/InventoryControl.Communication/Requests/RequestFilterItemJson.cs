using InventoryControl.Communication.Enums;

namespace InventoryControl.Communication.Requests
{
    public class RequestFilterItemJson
    {
        public string? ItemName { get; set; }
        public string? InternalCode { get; set; }
        public IList<Department> Departments { get; set; } = [];
        public IList<ProductType> ProductTypes { get; set; } = [];
        public ItemStatus? ItemStatus { get; set; }
    }
}
