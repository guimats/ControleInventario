namespace InventoryControl.Communication.Responses;

public class ResponseLoginResultJson
{
    public bool Valid { get; set; } = false;
    public IList<string> Message { get; set; } = [];
    public ResponseRegisteredUserJson? User { get; set; }
}
