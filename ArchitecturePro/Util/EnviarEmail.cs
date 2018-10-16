using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchitecturePro.Util
{
    public static class EnviarEmail
    {
        public static string nomeEmpresa { set; get; }
        public static string email { set; get; }
        public static string senha { set; get; }

        public static bool SendMail(string email, string assunto, string msg)
        {
            var ret = false;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);

                mail.From = new MailAddress(email, nomeEmpresa);
                mail.To.Add(email);
                mail.Subject = assunto;
                mail.Body = msg;

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email, senha);
                SmtpServer.EnableSsl = true;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.Send(mail);
                ret = true;
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow(string.Format("Erro ao tentar enviar o email para {0}: {1}", email, ex.Message), "Camila Moraes Arquitetura",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
    }
}
