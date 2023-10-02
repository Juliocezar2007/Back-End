// Somente declarando uma variavel do tipo inteira e sem valor
//int num1;

//Declarando uma variavel do tipo inteiro e atribuido valor 5
//int num2 = 5;

//Declarando variavel String
//string nomeAluno = "Paulo";

//variavel do tipo logico (true ou false)
//bool resultado = true;

//variavel do tipo double valor com varias casas decimais
//double coordenada = 1.803645628;

//variavel do tipo decimal - ultilizada para valores
//decimal valor = 1.80M;

int idade = 16;
string meuNome = "Julio";  
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");

Console.WriteLine("");
Console.WriteLine("Em qual cidade você nasceu");
//ReadLine serve apenas para que eu receba ima informação do usuario
//e armazeno em um variavel
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");