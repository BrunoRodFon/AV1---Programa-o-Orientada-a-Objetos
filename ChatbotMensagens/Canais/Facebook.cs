using ChatbotMensagens.Mensagens;

namespace ChatbotMensagens.Canais
{
    public class Facebook : ICanal
    {
        public string Destinatario { get; private set; }

        public Facebook(string usuario)
        {
            Destinatario = usuario;
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"\nEnviando via Facebook para {Destinatario}:");
            mensagem.ExibirDetalhes();
        }
    }
}
