namespace ChatbotMensagens.Mensagens
{
    public class MensagemFoto : Mensagem
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }

        public MensagemFoto(string conteudo, string arquivo, string formato)
            : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[Foto] {Conteudo} - Arquivo: {Arquivo}.{Formato} - Enviada em: {DataEnvio}");
        }
    }
}
