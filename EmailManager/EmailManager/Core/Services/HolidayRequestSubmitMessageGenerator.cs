using System;
using System.Collections.Generic;
using System.Text;
using Resources = EmailManager.Properties.Resources;

namespace EmailManager
{
    public class HolidayRequestSubmitMessageGenerator : BaseMessageGenerator
    {
        public HolidayRequestSubmitMessageGenerator(HolidayRequest holidayRequest, IMessageContact contact) : base(holidayRequest, contact) { }
        public override Message Get()
        {
            return new Message()
            {
                To = _contact.InboxAddress,
                Title = Resources.EMAIL_TITLE_HOLIDAY_REQUEST,
                Body = GenerateEmailBody()
            };
        }
        
        //CR: quite complicated. It is very hard to understand what's happened.
        private String GenerateEmailBody()
        {
            StringBuilder sb = new StringBuilder();
            string EMAIL_BODY_LINE_OF_INFORMATION_TEMPLATE = "{0}: {1}\n\r";

            Dictionary<string, string> pairsOfTitleAndValue = new Dictionary<string, string>()
            {
                {Resources.EMAIL_BODY_EMPLOYEE,  _holidayRequest.Employee.Name},
                {Resources.EMAIL_BODY_START_DATE,  _holidayRequest.HolidayInterval.StartDate.ToShortDateString()},
                {Resources.EMAIL_BODY_END_DATE,  _holidayRequest.HolidayInterval.EndDate.ToShortDateString()}
            };

            foreach (var pair in pairsOfTitleAndValue)
            {
                sb.AppendFormat(EMAIL_BODY_LINE_OF_INFORMATION_TEMPLATE, pair.Key, pair.Value);
            }
            return sb.ToString();
        }
    }
}
