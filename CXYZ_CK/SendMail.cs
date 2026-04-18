using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace CXYZ_CK
{
    public static class SendMail
    {
        public static string taikhoan = "supperstarvn123456@gmail.com";
        public static string matkhau = "ymhq fegw dhqv bagd";

        public static bool sendMailTo(string emailto, string content)
        {
            var fromAddress = new MailAddress(taikhoan, "Admin");
            var toAddress = new MailAddress(emailto, emailto);
            string fromPassword = matkhau;
            string subject = "Mã OTP!";
            string body = content;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            try
            {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
