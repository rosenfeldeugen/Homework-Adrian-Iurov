using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailManager;

namespace EmailManager
{
    public class Employee: IMessageContact
    {
        protected IMessageDispatcher _messageDispatcher;  

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string InboxAddress
        {
            get { return Email; }
        }
        public Manager Manager { get; private set; }



        public Employee(IMessageDispatcher messageDispatcher, string email, string name, Manager manager)
        {
            _messageDispatcher = messageDispatcher;
            Email = email;
            Name = name;
            Manager = manager;
        }

        public void SubmitHolidayRequest(HolidayRequest holidayRequest)
        {
            Message message= new HolidayRequestSubmitMessageGenerator(holidayRequest, Manager).Get();
            _messageDispatcher.Send(message);
        }
    }
}
