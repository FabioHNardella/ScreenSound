// Screen Sound

// Variáveis

string boasVindas = "Bem vindo(a) ao Screen Sound!";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); 
bandasRegistradas.Add("the beatles", new List<int>{10, 8, 6});
bandasRegistradas.Add("foo fighters", new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

// Criação de FUNÇÕES
void ExibirLogo(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
---------------------------------------------------------------------------------------------");
    Console.WriteLine(boasVindas);
}
void ExibirMenu(){
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda\n");
    Console.WriteLine("Digite 2 para mostrar todas as bandas\n");
    Console.WriteLine("Digite 3 para avaliar uma banda\n");
    Console.WriteLine("Digite 4 para exibir a média de uma banda\n");
    Console.WriteLine("Digite -1 para sair\n");
    Console.Write("Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
    switch(opcaoEscolhidaNumero){
        case 1: RegistrarBanda();
            break;
        case 2: ExibirBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMediasBandas();
            break;
        case -1: Console.WriteLine("\nAdios.");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}
void RegistrarBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    ExibirMenu();
}
void ExibirBandas(){
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    ExibirMenu();
}
void ExibirTituloDaOpcao(string titulo){
    int quantidadeLetras = titulo.Length;
    string asteristico = string.Empty.PadLeft(quantidadeLetras,'-');
    Console.WriteLine(asteristico);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristico+"\n");
}
void AvaliarBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeBanda)){
        Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA banda {nomeBanda} recebeu a nota {nota} com sucesso!");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirMenu();
    }
    else{
        Console.WriteLine($"\nA banda {nomeBanda} não está registrada!");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirMenu();
        }
}
void ExibirMediasBandas(){
    
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas:");
    foreach (string banda in bandasRegistradas.Keys){
        Console.WriteLine($"Banda: {banda}");
    }
    ExibirTituloDaOpcao("\nDigite o nome da banda você deseja ver a média: ");
    string bandaEscolhida = Console.ReadLine()!;
    Console.Clear();
    if(bandasRegistradas.ContainsKey(bandaEscolhida)){
        Console.Write($"\nNotas da banda {bandaEscolhida}: ");
        foreach (int nota in bandasRegistradas[bandaEscolhida]){
            Console.Write($"{nota} | ");
        }
        List<int> notasBandas = bandasRegistradas[bandaEscolhida];
        double media = notasBandas.Average();
        Console.WriteLine($"\nMédia: {media}");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
        Console.ReadKey();
        ExibirMenu();
    }
    else{
        Console.WriteLine($"\nA banda {bandaEscolhida} não está registrada!");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
        Console.ReadKey();
        ExibirMenu();
    }
}

// Chamar Funções para RODAR O PROGRAMA
ExibirMenu();