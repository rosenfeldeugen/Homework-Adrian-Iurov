using EmailManager.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager
{
    public class HolidayRequestApproveMessageGenerator : BaseMessageGenerator
    {
        public HolidayRequestApproveMessageGenerator(HolidayRequest holidayRequest, IMessageContact contact) : base(holidayRequest, contact) { }
        public override Message Get()
        {
            return new Message()
            {
                To = _contact.InboxAddress,
                Title = Resources.EMAIL_TITLE_HOLIDAY_REQUEST_APPROVED,
                Body = Resources.EMAIL_TITLE_HOLIDAY_REQUEST_APPROVED
            };
        }
    }
}
