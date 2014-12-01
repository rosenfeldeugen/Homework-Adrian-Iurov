using System;

namespace EmailManager
{
    public class Manager : BaseUser
    {
        //CR: Is not needed to prefix the private fields with underscore. This add no value to the code.
        private IMessageDispatcher _messageDispatcher;  

        public Manager(IMessageDispatcher messageDispatcher, string email, string name)
            : this(messageDispatcher, email, name, null)
        {
            //CR: Circular reference on Manager? The manager is his own manager?
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

        //CR: this is not used. Do you want to chain managers?
        public bool IsTopManager()
        {
            return this == this.Manager;
        }
    }
}
