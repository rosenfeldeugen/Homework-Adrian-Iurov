using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager
{
    public class HolidayRequest
    {
        public Employee Employee { get; private set; }

        public HolidayInterval HolidayInterval { get; private set; }
        
        public HolidayRequest(Employee employee, HolidayInterval holidayInterval)
        {
            Employee = employee;
            HolidayInterval = holidayInterval;
        }
    }
}
