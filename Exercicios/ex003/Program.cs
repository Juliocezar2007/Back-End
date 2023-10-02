Console.WriteLine("Digite o numero do mês:");
int meses = int.Parse(Console.ReadLine());

switch (meses)
{
    case 1:
    Console.WriteLine("janeiro, 31 dias");
    break;
    case 2:
    Console.WriteLine("feverero, 28 dias");
    break;

case 3:
    Console.WriteLine("março, 31 dias");
    break;

case 4:
    Console.WriteLine("Abril, 3o dias");
    break;

case 5:
    Console.WriteLine("Maio, 31 dias");
    break;
case 6:
    Console.WriteLine("Junho, 30 dias");
    break;

case 7:
    Console.WriteLine("julho, 31 dias");
    break;

case 8:
    Console.WriteLine("Agosto, 31 dias");
    break;

case 9:
    Console.WriteLine("Setembro, 30 dias");
    break;

case 10:
    Console.WriteLine("Outubro, 31 dias");
    break;

case 11:
    Console.WriteLine("Novenbro, 30 dias");
    break;

case 12:
    Console.WriteLine("Dezembro, 31 dias");
    break;
 default:
 Console.WriteLine("Mês invalido");
 break;



}