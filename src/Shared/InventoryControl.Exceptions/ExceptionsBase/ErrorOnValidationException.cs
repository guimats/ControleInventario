using System.Net;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : InventoryControlException
    {
        private readonly IList<string> _errorMessages;

        public ErrorOnValidationException(IList<string> errorMessages) : base(string.Empty)
        {
            _errorMessages = errorMessages;
        }

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.BadRequest;

        public override IList<string> GetMessages() => _errorMessages;
    }
}
