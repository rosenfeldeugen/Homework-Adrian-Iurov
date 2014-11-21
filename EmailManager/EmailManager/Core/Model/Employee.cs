namespace EmailManager
{
    public class Employee: BaseUser
    {
        private IMessageDispatcher _messageDispatcher;  

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
