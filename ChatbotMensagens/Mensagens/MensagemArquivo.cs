namespace ChatbotMensagens.Mensagens
{
    public class MensagemArquivo : Mensagem
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }

        public MensagemArquivo(string conteudo, string arquivo, string formato)
            : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[Arquivo] {Conteudo} - Arquivo: {Arquivo}.{Formato} - Enviada em: {DataEnvio}");
        }
    }
}
