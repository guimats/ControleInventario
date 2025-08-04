using System.Net;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public abstract class InventoryControlException : SystemException
    {
        public InventoryControlException(string message) : base(message) { }

        public abstract HttpStatusCode GetStatusCode();

        public abstract IList<string> GetMessages();
    }
}
