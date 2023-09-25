using conta;

public class program
{
    public static void Main()
    {

        Console.Clear();
        Console.WriteLine("---------------------");
        Console.WriteLine("Bem-vindo a sua conta");
        Console.WriteLine("---------------------");

        Menu();
    }
    public static void Menu()
    {
        Console.WriteLine("Digite o nome do titular");
        string titular = Console.ReadLine();

        var conta1 = new corrente(titular);
        string opcao = "";
        do
        {
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Para consultar o saldo");
            Console.WriteLine("2 - Para depositar");
            Console.WriteLine("3 - Para sacar");
            Console.WriteLine("0 - Para sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre:");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    conta1.ConsultarSaldo();
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "2":
                    Console.WriteLine("Digite o valor que quer depositar:");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    conta1.Depositar(valor);
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "3":
                    Console.WriteLine("Digite o valor que quer sacar:");

                    decimal valor2 = decimal.Parse(Console.ReadLine());
                    conta1.SacarSaldo(valor2);
                    System.Threading.Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Opção invalida:");
                    break;
            }

        } while (opcao != "0");
    }
}