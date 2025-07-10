namespace InventoryControl.Domain.Entities
{
    public class ItemHistory : EntityBase
    {
        public long ItemId { get; set; }
        public string Action { get; set; } = string.Empty;
        public string UserName { get; set; }  = string.Empty;
        public string? OldData { get; set; }
        public string? NewData { get; set; }

        public Item? Item { get; set; } // navegação
    }
}
