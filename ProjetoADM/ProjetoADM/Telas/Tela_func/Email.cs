using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Telas.Tela_func
{
    class Email
    {
        public string Para { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }


        MailMessage email = new MailMessage();

        public void Enviar()
        {
            Task.Factory.StartNew(() =>
            {
                // Se for usar seu email, habilite ele em: https://myaccount.google.com/lesssecureapps?pli=1
                string remetente = "mathclash25@gmail.com";
                string senha = "matheus250302";


                // Configura Remetente, Destinatário
                email.From = new MailAddress(remetente);
                email.To.Add(this.Para);


                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = this.Assunto;
                email.Body = this.Mensagem;
                email.IsBodyHtml = true;


                // Configura os parâmetros do objeto SMTP
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                // Atribui credenciais
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(remetente, senha);


                // Envia a mensagem
                smtp.Send(email);

            });
        }


        public void AdicionarAnexo(string arquivo)
        {
            Attachment inline = new Attachment(arquivo);
            this.email.Attachments.Add(inline);
        }

    }
}
