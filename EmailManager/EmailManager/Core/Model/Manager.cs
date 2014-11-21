using System;

namespace EmailManager
{
    public class Manager : BaseUser
    {
        private IMessageDispatcher _messageDispatcher;  

        public Manager(IMessageDispatcher messageDispatcher, string email, string name)
            : this(messageDispatcher, email, name, null)
        {
            Manager = this;
        }

        public Manager(IMessageDispatcher messageDispatcher, string email, string name, Manager manager)
            : base(email, name, manager)
        {
            _messageDispatcher = messageDispatcher;
        }

        public void ApproveHolidayRequest(HolidayRequest holidayRequest, HR hr)
        {
            Message message = new HolidayRequestApproveMessageGenerator(holidayRequest, hr).Get();
            _messageDispatcher.Send(message);
        }

        public void RejectHolidayRequest(HolidayRequest holidayRequest, String reason)
        {
            Message message = new HolidayRequestRejectMessageGenerator(holidayRequest, holidayRequest.Employee, reason).Get();
            _messageDispatcher.Send(message);
        }
        public bool IsTopManager()
        {
            return this == this.Manager;
        }
    }
}
