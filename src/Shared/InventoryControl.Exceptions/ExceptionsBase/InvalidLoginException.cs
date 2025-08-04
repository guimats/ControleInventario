using System.Net;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class InvalidLoginException : InventoryControlException
    {
        public InvalidLoginException() : base(ResourceMessagesException.EMAIL_OR_PASSWORD_INVALID)
        {
        }

        public override IList<string> GetMessages() => [Message];

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
    }
}
