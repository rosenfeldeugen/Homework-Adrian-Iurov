using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager
{
    class Program
    {
        static void Main(string[] args)
        {
            MailSender mailSender = new MailSender();
            HR hr = new HR("hr@x.com");
            Manager manager = new Manager(mailSender, "m@x.com", "M");
            Employee employee = new Employee(mailSender, "a@x.com", "A", manager);


            HolidayRequest request = new HolidayRequest(employee, new HolidayInterval(new DateTime(2014, 12, 1), new DateTime(2014, 12, 15)));
            employee.SubmitHolidayRequest(request);

            manager.RejectHolidayRequest(request, "get to work!");
            
            manager.ApproveHolidayRequest(request, hr);
        }
    }
}
