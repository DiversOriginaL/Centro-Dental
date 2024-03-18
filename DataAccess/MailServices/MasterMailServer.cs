using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DataAccess.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string SenderMail { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool ssl { get; set; }

        protected void InitialSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(SenderMail, Password);
            smtpClient.Host = Host;
            smtpClient.Port = Port;
            smtpClient.EnableSsl = ssl;
        }

        public void SendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(SenderMail);
                foreach (var Mail in recipientMail)
                {
                    mailMessage.To.Add(Mail);

                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);

            }
            catch (Exception ex){

            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
            
        }
    }
}
