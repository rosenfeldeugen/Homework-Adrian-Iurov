namespace EmailManager
{
    public class Employee: BaseUser
    {
        //CR: this class depends on the message dispatcher and on the HolidayRequest.
        //CR: Move the dependency on MessageDispatcher into the HolidayRequest.
        //CR: Is not needed to prefix the private fields with underscore. This add no value to the code.
        private IMessageDispatcher _messageDispatcher;

        //CR: Not needed to have a manager here. You can pass it in SubmitHolidayRequest
        public Employee(IMessageDispatcher messageDispatcher, string email, string name, Manager manager): base(email, name, manager)
        {
            _messageDispatcher = messageDispatcher;
        }
        
        public void SubmitHolidayRequest(HolidayRequest holidayRequest)
        {
            Message message= new HolidayRequestSubmitMessageGenerator(holidayRequest, Manager).Get();
            _messageDispatcher.Send(message);
        }
    }
}
