// Screen Sound
string mensagemDeBoasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8, 8 });
bandasRegistradas.Add("RHCP", new List<int>());

void ExibirLogo()
{
    Console.WriteLine($"{mensagemDeBoasVindas}\n");
    Console.WriteLine("Boas vindas ao ScreenSound!\n");
}

void ExibirMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir uma média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaToInt = int.Parse(opcaoEscolhida);

    //Use a instrução switch para selecionar um dos muitos blocos de código a serem executados.
    switch (opcaoEscolhidaToInt)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break;
        case 5: Console.WriteLine("Tchau Tchau T_T");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

//Opção 1
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine($"{mensagemDeBoasVindas}\n");
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();

    ExibirLogo();
    ExibirMenu();
}

//Opção 2
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine($"{mensagemDeBoasVindas}\n");
    ExibirTituloDaOpcao("Lista das Bandas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();

    ExibirLogo();
    ExibirMenu();
}

//Opção 3
void AvaliarUmaBanda()
{
    Console.Clear();
    Console.WriteLine($"{mensagemDeBoasVindas}\n");
    ExibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("Digite o nome da banda para avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite a sua nota para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("\nNota registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();

        ExibirLogo();
        ExibirMenu();

    } else
    {
        Console.WriteLine($"A banda {nomeDaBanda} ainda não foi registrada");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

        ExibirLogo();
        ExibirMenu();
    }
}

//Opção 4
void ExibirMedia()
{
    Console.Clear();
    Console.WriteLine($"{mensagemDeBoasVindas}\n");
    ExibirTituloDaOpcao("Média de nota das bandas");
    Console.Write("Digite o nome da banda para ver sua média de notas: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> mediaDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média de nota da banda {nomeDaBanda} é: {mediaDaBanda.Average()}");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

        ExibirLogo();
        ExibirMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} ainda não foi registrada");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

        ExibirLogo();
        ExibirMenu();
    }
}



//Título opção
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

ExibirLogo();
ExibirMenu();