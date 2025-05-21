using ChatbotMensagens.Mensagens;

namespace ChatbotMensagens.Canais
{
    public interface ICanal
    {
        string Destinatario { get; }
        void EnviarMensagem(Mensagem mensagem);
    }
}
