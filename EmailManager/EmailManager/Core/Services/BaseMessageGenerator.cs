namespace EmailManager
{
    public abstract class BaseMessageGenerator
    {
        //CR: Is not needed to prefix the private fields with underscore. This add no value to the code.
        protected HolidayRequest _holidayRequest;
        //CR: you can replace IMessageContact contact, with string InboxAddress
        protected IMessageContact _contact;
        
        protected BaseMessageGenerator(HolidayRequest holidayRequest, IMessageContact contact)
        {
            _holidayRequest = holidayRequest;
            _contact = contact;
        }

        public abstract Message Get();
    }
}
