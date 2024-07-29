using System.Globalization;
using System.Net;
using System.Net.Mail;
internal class Program
{
    private static void Main(string[] args)
    {
        String fromMail = "tapp93550@gmail.com";
        string fromPass = "hijl zvbh ciyg sacu";
        MailMessage message = new MailMessage();
        message.From = new MailAddress(fromMail);
        message.Subject = "Test";
        message.To.Add(new MailAddress("srividya.mom@gmail.com"));
        message.Body = "<html><body><h1>Testing app</h1></body></html>";
        message.IsBodyHtml= true;

        var smtp = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential(fromMail, fromPass),
            EnableSsl = true
        };
        smtp.Send(message);
    }
}