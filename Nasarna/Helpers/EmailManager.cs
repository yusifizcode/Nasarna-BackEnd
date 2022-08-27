using System.Net.Mail;
using System.Threading.Tasks;

namespace Nasarna.Helpers
{
    public static class EmailManager
    {
        public async static Task SendEmailAsync(string email, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("5ba0gh2@code.edu.az");
            mail.Subject = subject;
            string Body = body;
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("5ba0gh2@code.edu.az", "sbjitesfuqpdwrbo");
            smtp.EnableSsl = true;

            await smtp.SendMailAsync(mail);
            

        }
    }
}
