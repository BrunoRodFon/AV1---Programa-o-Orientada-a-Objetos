namespace ChatbotMensagens.Mensagens
{
    public class MensagemTexto : Mensagem
    {
        public MensagemTexto(string conteudo) : base(conteudo) { }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[Texto] {Conteudo} - Enviada em: {DataEnvio}");
        }
    }
}
