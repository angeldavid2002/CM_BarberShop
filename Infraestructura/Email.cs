using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entidades;
namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }
        private void ConfigurarSmt() 
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("angeldavidbolanoaroca@gmail.com","angel2002");
        }
        private void ConfigurarEmail(string correo,string ruta) 
        {
            email = new MailMessage();
            email.To.Add(correo);
            email.From = new MailAddress("angeldavidbolanoaroca@gmail.com");
            email.Subject = "Registro de Usuario "
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr angel david bolaño aroca </b> <br " +
                $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.Attachments.Add(new Attachment(ruta));
        }
        public string EnviarEmail(string correo,string ruta) 
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(correo,ruta);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }

        }

    }
}
