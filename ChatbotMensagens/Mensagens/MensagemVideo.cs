namespace ChatbotMensagens.Mensagens
{
    public class MensagemVideo : Mensagem
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }
        public int DuracaoSegundos { get; set; }

        public MensagemVideo(string conteudo, string arquivo, string formato, int duracao)
            : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
            DuracaoSegundos = duracao;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[Vídeo] {Conteudo} - Arquivo: {Arquivo}.{Formato} - Duração: {DuracaoSegundos}s - Enviada em: {DataEnvio}");
        }
    }
}
