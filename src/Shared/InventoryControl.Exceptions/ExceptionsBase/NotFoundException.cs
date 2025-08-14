using System.Net;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class NotFoundException : InventoryControlException
    {
        public NotFoundException(string message) : base(message) { }

        public override IList<string> GetMessages() => [Message];
        public override HttpStatusCode GetStatusCode() => HttpStatusCode.NotFound;
    }
}
