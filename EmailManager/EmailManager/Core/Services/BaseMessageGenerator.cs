namespace EmailManager
{
    public abstract class BaseMessageGenerator
    {
        protected HolidayRequest _holidayRequest;
        protected IMessageContact _contact;
        protected BaseMessageGenerator(HolidayRequest holidayRequest, IMessageContact contact)
        {
            _holidayRequest = holidayRequest;
            _contact = contact;
        }

        public abstract Message Get();
    }
}
