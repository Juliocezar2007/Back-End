using System.IO;

public class Program
{
    public static string  caminhoArquivo = "Arquivo/arquivo2.txt";
    public static void Main()
    {
        //Chamando o método GravarArquivo
        Gravararquivo();
        //Chamando o método LerArquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {
        try
        {
            string caminhoArquivo = "Arquivo/arquivo.txt";

            //verificar se o arquivo existe
            if (File.Exists("Arquivo/arquivo.txt") == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando
                //a verificação no if é falsa ou seja o arquivo não existe
                File.Create(caminhoArquivo);
            }

        //Instanciando um objeto da class StreaWriter para ler o arquivo
        using (StreamReader arquivo = new StreamReader(caminhoArquivo))
        {
            string linha;
            //Fazendo o while para ler linha por linha que contêm no arquivo
            while ((linha = arquivo.ReadLine()) != null)
            {
                //Escrevendo no console o conteudo da linha
                Console.WriteLine(linha);
            }
        }
        }
        catch (Exception erro)
        {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
            }
        
    }

    public static void Gravararquivo()
    {


        try
        {
            //Instanciando um objeto da class StreaWriter para gravar em arquivo
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                Console.WriteLine("Digite um texto para salvar no arquivo");
                string texto = Console.ReadLine();
                arquivo.WriteLine(texto);
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }
    }
}
