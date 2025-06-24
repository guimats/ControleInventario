namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : InventoryControlException
    {
        public IList<string> ErrorMessages { get; set; }

        public ErrorOnValidationException(IList<string> errorMessages) : base(string.Empty)
        {
            ErrorMessages = errorMessages;
        }
    }
}
