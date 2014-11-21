using EmailManager.Properties;
using System;

namespace EmailManager
{
    public class HolidayRequestRejectMessageGenerator : BaseMessageGenerator
    {
        private String _reason;
        public HolidayRequestRejectMessageGenerator(HolidayRequest holidayRequest, IMessageContact contact, String reason)
            : base(holidayRequest, contact)
        {
            _reason = reason;
        }
        public override Message Get()
        {
            return new Message()
            {
                To = _contact.InboxAddress,
                Title = Resources.EMAIL_TITLE_HOLIDAY_REQUEST_REJECTED,
                Body = String.Format(Resources.EMAIL_BODY_HOLIDAY_REQUEST_REJECTED, _reason)
            };
        }
    }
}
