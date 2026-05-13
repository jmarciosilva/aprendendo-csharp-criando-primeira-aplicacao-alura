// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

// criando uma função local para exibir a mensagem de boas vindas
void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
█████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
█▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀
");
    Console.WriteLine(mensagemDeBoasVindas);
}

// criando função de menu para o usuário escolher as opções
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("Digite 1 - Registrar uma Banda");
    Console.WriteLine("Digite 2 - Mostrar todas as Bandas");
    Console.WriteLine("Digite 3 - Avaliar uma Banda");
    Console.WriteLine("Digite -1 - Sair");
    Console.Write("\nDigite a opção desejada: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    // aqui você pode adicionar a lógica para lidar com as opções escolhidas pelo usuário
    if (opcaoEscolhida == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
}

// chamando a função local para exibir a mensagem de boas vindas
ExibirMensagemDeBoasVindas();

// chamando a função local para exibir as opções do menu
ExibirOpcoesDoMenu();


