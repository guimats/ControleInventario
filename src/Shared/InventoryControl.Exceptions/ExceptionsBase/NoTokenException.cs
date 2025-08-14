using System.Net;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class NoTokenException : InventoryControlException
    {
        public NoTokenException() : base(ResourceMessagesException.NO_TOKEN) { }

        public override IList<string> GetMessages() => [Message];

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
    }
}
