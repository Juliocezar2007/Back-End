Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

//Exemplo de operadores aritimeticos 
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;
int restoDiv3 = y % 2;

//Console para exibir na tela as variaveis em cada linha 
//Soma: 15
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtracao: {subtracao}"  );
Console.WriteLine($"Multiplicacao: {multiplicacao}" );
Console.WriteLine($"Divisao: {divisao}" );
Console.WriteLine($"resto: {resto}" );


if (restoDiv2 == 0)
{
    Console.WriteLine($"O numero {x} é par");
}
else
{
    Console.WriteLine($"O numero {x} é impar");
}


if (restoDiv3 == 0)
{
    Console.WriteLine($"O numero {y} é par");
}
else
{
    Console.WriteLine($"O numero {y} é impar");
}

//operador termario
// condição ? se verdade : senão 
string resultado = (restoDiv2== 0) ? $"O numero {y} é par" : $"O numero {y} é impar";
Console.WriteLine(resultado);


int diaSemana = 3;
//Aprendendo o switch case
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é Domingo!");
        break;

    case 2:
        Console.WriteLine("Hoje é Segunda!");
        break;

    case 3:
        Console.WriteLine("Hoje é Terça!");
        break;

    case 4:
        Console.WriteLine("Hoje é Quarta!");
        break;

    case 5:
        Console.WriteLine("Hoje é Quinta!");
        break;

    case 6:
        Console.WriteLine("Hoje é Sexta!");
        break;

    case 7:
        Console.WriteLine("Hoje é Sabado!");
        break;
    default:
        Console.WriteLine("Dia invalido");
        break;
}
 




