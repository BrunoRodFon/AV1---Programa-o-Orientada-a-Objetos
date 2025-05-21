using ChatbotMensagens.Mensagens;

namespace ChatbotMensagens.Canais
{
    public class Telegram : ICanal
    {
        public string Destinatario { get; private set; }

        public Telegram(string identificador)
        {
            Destinatario = identificador;
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"\nEnviando via Telegram para {Destinatario}:");
            mensagem.ExibirDetalhes();
        }
    }
}
