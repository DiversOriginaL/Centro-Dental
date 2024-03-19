using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            SenderMail = "clinicadentalpopular1a@gmail.com";
            Password = "qfsqkcduuemferyo";
            Host = "smtp.gmail.com";
            Port = 587;
            ssl = true;
            InitialSmtpClient();

        }
    }
}
