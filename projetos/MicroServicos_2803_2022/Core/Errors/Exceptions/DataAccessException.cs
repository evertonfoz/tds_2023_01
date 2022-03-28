namespace PostoDeGasolinaLibrary.Core.Errors.Exceptions
{
    public class DataAccessException : Exception
    {
        public string message { get; init; }
        public DataAccessException(String message) : base(message)
        {
            this.message = message;
        }
    }
}
