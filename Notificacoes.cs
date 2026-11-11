using System;

namespace ListaHeranca
{
    public class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Enviando uma notificação genérica...");
        }
    }

    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando e-mail: Assunto 'Bem-vindo' para o destinatário.");
        }
    }

    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando SMS: 'Seu código de verificação é 1234'.");
        }
    }

    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando Push Notification: 'Você tem uma nova curtida!'");
        }
    }
}