namespace InventoryControl.Communication.Responses
{
    public class ResponseItemHistoryJson
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? OldData { get; set; }
        public string? NewData { get; set; }
    }
}
