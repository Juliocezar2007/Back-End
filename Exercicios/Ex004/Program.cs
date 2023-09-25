class programa
{
    public static void Main()
    {
        Console.Clear();

        string DesejaContinuar ="y";
        while(DesejaContinuar == "y")
        {
            Console.Write("Digite um numero para saber a taboada dele :> ");
            float Numeroparaataboada = float.Parse(Console.ReadLine());
            TabuadacomWhile(Numeroparaataboada);

             Console.Write("Digite um numero para saber qual é o dobro dele :> ");
            float NumeroParaODobro = float.Parse(Console.ReadLine());
           Console.WriteLine(Dobro(NumeroParaODobro));

            Console.Write("Digite um numero para saber qual sera a metade dele :> ");
            float NumeroParaaMetade = float.Parse(Console.ReadLine());
            Console.WriteLine(Metade(NumeroParaaMetade));

            Console.Write("Deseja continuar? y/n :> ");
            DesejaContinuar = Console.ReadLine();
        }
        Console.Clear();
    }

    public static string Metade(float Num)
    {
        return $"O Metade de {Num} é {Num / 2}";
    }

    public static string Dobro(float Num)
    {
        return $"O dobro de {Num} é {Num * 2}";
    }

    public static void TabuadacomWhile(float Num)

    {
        int contador =0;

        while (contador < 10){
            contador++;

        Console.WriteLine($"{Num} x {contador} = {Num * contador}");
        }

        
    }

    public static void SomaComDowhile()
    {
        float MENOR = 0;
        float MAIOR = 0;
        float Soma = 0;
        do
        {
            Console.WriteLine("");

            Console.Write("Escreva um numero positivo :> ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            if (Num1 < 0)
            {
                break;
            }

            if (Num1 > MAIOR)
            {
                MAIOR = Num1;
            }else{
                MENOR = Num1;
            }

            Console.WriteLine($"{Soma} + {Num1} = {Soma + Num1}");
            Soma = Soma + Num1;
            Console.WriteLine(" ");

        }while (true);

        Console.WriteLine(" ");
        Console.WriteLine("Numero negativo detectando, saindo do loop");
        Console.WriteLine(" ");





    }





}