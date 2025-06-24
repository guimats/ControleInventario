namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class InvalidLoginException : InventoryControlException
    {
        public InvalidLoginException() : base(ResourceMessagesException.EMAIL_OR_PASSWORD_INVALID)
        {
        }
    }
}
