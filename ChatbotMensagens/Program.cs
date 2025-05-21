using ChatbotMensagens.Canais;
using ChatbotMensagens.Mensagens;

Console.WriteLine("=== SISTEMA DE ENVIO AUTOMÁTICO DE MENSAGENS ===\n");

// Escolher canal
Console.WriteLine("Escolha o canal para envio:");
Console.WriteLine("1 - WhatsApp");
Console.WriteLine("2 - Telegram");
Console.WriteLine("3 - Facebook");
Console.WriteLine("4 - Instagram");
Console.Write("Opção: ");
var canalOpcao = Console.ReadLine();

ICanal canalSelecionado = canalOpcao switch
{
    "1" => CriarCanalTelefone("WhatsApp"),
    "2" => CriarCanalTelefoneOuUsuario("Telegram"),
    "3" => CriarCanalUsuario("Facebook"),
    "4" => CriarCanalUsuario("Instagram"),
    _ => throw new InvalidOperationException("Opção de canal inválida")
};

// Mensagens fixas para enviar
var mensagens = new Mensagem[]
{
    new MensagemTexto("Mensagem de texto automática."),
    new MensagemFoto("Foto automática", "foto.jpg", "jpg"),
    new MensagemVideo("Vídeo automático", "video.mp4", "mp4", 120),
    new MensagemArquivo("Arquivo automático", "documento.pdf", "pdf")
};

// Enviar todas as mensagens
foreach (var msg in mensagens)
{
    canalSelecionado.EnviarMensagem(msg);
}

// Métodos auxiliares para criar canais

ICanal CriarCanalTelefone(string nome)
{
    Console.Write("Digite o número de telefone: ");
    string numero = Console.ReadLine() ?? "";

    return nome switch
    {
        "WhatsApp" => new WhatsApp(numero),
        "Telegram" => new Telegram(numero),
        _ => throw new InvalidOperationException("Canal não suportado com número de telefone.")
    };
}

ICanal CriarCanalUsuario(string nome)
{
    Console.Write("Digite o nome de usuário: ");
    string usuario = Console.ReadLine() ?? "";

    return nome switch
    {
        "Facebook" => new Facebook(usuario),
        "Instagram" => new Instagram(usuario),
        _ => throw new InvalidOperationException("Canal não suportado com nome de usuário.")
    };
}

ICanal CriarCanalTelefoneOuUsuario(string nome)
{
    Console.WriteLine("Deseja usar:");
    Console.WriteLine("1 - Número de telefone");
    Console.WriteLine("2 - Nome de usuário");
    Console.Write("Opção: ");
    string tipo = Console.ReadLine() ?? "";

    return tipo switch
    {
        "1" => CriarCanalTelefone("Telegram"),
        "2" => CriarCanalUsuario("Telegram"),
        _ => throw new InvalidOperationException("Tipo inválido.")
    };
}
