
namespace EmailManager
{
    public class BaseUser : IMessageContact
    {
        public string Name { get; private set; }

        public string Email { get; private set; }
       
        //CR: The employee should have a manager. Or even better, the HolidayRequest should have an approver.
        public Manager Manager { get; protected set; }

        //CR: this is not needed
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
