using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Approval_management.DataModel.Email
{
    public class Emailnotification
    {
        public static string EmailNotification()
        {
            MailMessage message = new MailMessage("ambujlaala092@gmail.com", "ambujsrivastava092@gmail.com");
            message.Subject = "New request from employee";
            message.Body = "You have request for approval";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            System.Net.NetworkCredential credential = new System.Net.NetworkCredential();
            credential.UserName = "ambujlaala092@gmail.com";
            credential.Password = "Ambuj@1997";
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credential;

            smtp.Send(message);

            return "Success";
        }
    }
}
