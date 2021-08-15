using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Site1.Library.Mail {
    public class EnviarEmail {

        public static void EnviarMensagemContato(Contato contato) {

            string conteudo = string.Format("Nome: {0}<br /> Email: {1}<br /> Assunto: {2}<br /> Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            //Configurar Servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

            //Mensagem de Email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("tutorialaprendizdedev@gmail.com"); //Remetente - Quem está enviando
            mensagem.To.Add("tutorialaprendizdedev@gmail.com"); //Destinatário - Quem recebe a mensagem
            mensagem.Subject = "Formulário de contato"; //Assunto do email
            mensagem.IsBodyHtml = true; //O corpo do email é um HTML - Verdadeiro
            mensagem.Body = "<h1>Formulário de Contato</h1>" + conteudo; //Corpo do email em HTML, neste caso!

            smtp.Send(mensagem);
        }
    }
}
