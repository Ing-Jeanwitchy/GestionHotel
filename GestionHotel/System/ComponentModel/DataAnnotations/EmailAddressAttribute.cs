namespace System.ComponentModel.DataAnnotations
{
    class EmailAddressAttribute
    {
        public EmailAddressAttribute()
        {
        }

        internal bool IsValid(string email)
        {
            throw new NotImplementedException();
        }
    }
}