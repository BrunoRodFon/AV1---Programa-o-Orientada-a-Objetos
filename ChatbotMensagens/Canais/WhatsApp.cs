using ChatbotMensagens.Mensagens;

namespace ChatbotMensagens.Canais
{
    public class WhatsApp : ICanal
    {
        public string Destinatario { get; private set; }

        public WhatsApp(string numeroTelefone)
        {
            Destinatario = numeroTelefone;
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"\nEnviando via WhatsApp para {Destinatario}:");
            mensagem.ExibirDetalhes();
        }
    }
}
