using System;

namespace EmailManager
{
    public class HolidayInterval
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public HolidayInterval(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
