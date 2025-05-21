using ChatbotMensagens.Mensagens;

namespace ChatbotMensagens.Canais
{
    public class Instagram : ICanal
    {
        public string Destinatario { get; private set; }

        public Instagram(string usuario)
        {
            Destinatario = usuario;
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"\nEnviando via Instagram para {Destinatario}:");
            mensagem.ExibirDetalhes();
        }
    }
}
