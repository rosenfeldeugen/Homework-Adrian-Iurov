using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources = EmailManager.Properties.Resources;

namespace EmailManager
{
    public class MailSender : IMessageDispatcher
    {
        public void Send(Message message)
        {
            //do the .NET email sending
        }
    }
}
