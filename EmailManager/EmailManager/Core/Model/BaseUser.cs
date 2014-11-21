
namespace EmailManager
{
    public class BaseUser : IMessageContact
    {
        public string Name { get; private set; }

        public string Email { get; private set; }
       
        public Manager Manager { get; protected set; }

        public string InboxAddress
        {
            get { return Email; }
        }

        public BaseUser(string email, string name, Manager manager)
        {
            Email = email;
            Name = name;
            Manager = manager;
        }
    }
}
