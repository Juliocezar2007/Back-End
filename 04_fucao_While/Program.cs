//Função em JavaScript
//function nomeFuncao (nome){
//}

//função / Método em c#
//public static string NomeFuncao(string nome) {
//}

class Sesi
{
    public static void Main()
    {
        //Chamando métodos sem retorno
        MostrarMensagem("Seja bem vindo");
        MostrarMensagem("SESI / SENAI");
        ImprimiDataHora();
        //chamando o método potenciado com o parãmetro 4 e recebendo o retorno
        double potencia = potenciacao(4);
        Console.WriteLine($"potenciacao {potencia}");

        ContagemRegressiva(10);
    }

    public static double potenciacao(int num){
        double resultado = Math.Pow(num, 2);
        return resultado;
    }


    //Método sem parãmetro e sem retorno
    public static void ImprimiDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }


    //Método com prãmentro e sem retorno
    public static void MostrarMensagem(string menssagem)
    {
        Console.WriteLine(menssagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >=0)
        {
            Console.WriteLine(n);
            n--;  //n = n-1
            System.Threading.Thread.Sleep(1000); //500 ms
        }
        Console.WriteLine("BOOOOOOM");
    }

    public static void JogoQueNRSouEu()
    {
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * ");
        Console.WriteLine("        Bem vindo ao Jogo       ");
        Console.WriteLine("Sorteei um nº de 1 a 20 , tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * ");
        Console.WriteLine(""); //Linha em branco 

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do {
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O número digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
                Console.WriteLine("O número digitado é MENOR que o sorteado");
        } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabéns você acertou");
    }

}
