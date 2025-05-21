namespace ChatbotMensagens.Mensagens
{
    public abstract class Mensagem
    {
        public string Conteudo { get; set; }
        public DateTime DataEnvio { get; private set; }

        public Mensagem(string conteudo)
        {
            Conteudo = conteudo;
            DataEnvio = DateTime.Now;
        }

        public abstract void ExibirDetalhes();
    }
}
