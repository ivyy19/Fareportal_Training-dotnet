namespace UserExceptions
{
    class AccountNotFoundException : ApplicationException
    {
        public AccountNotFoundException(string message) : base(message) { }
    }
}