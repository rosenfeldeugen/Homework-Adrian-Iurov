namespace EmailManager
{
    public class HR: IMessageContact
    {
        public string Email { get; private set; }

        public string InboxAddress
        {
            get { return Email; }
        }

        public HR(string email)
        {
            Email = email;
        }
    }
}
