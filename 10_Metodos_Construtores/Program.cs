using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da classe pessoa
        //Instanciando sem um método construtor
        /*Pessoa Pessoa1 = new Pessoa();
        Pessoa1.nome = "Douglas";
        Pessoa1.idade = 25;
        Pessoa1.Cantar();

        //Alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "Ricardo",
            idade = 22
        };
        pessoa2.Cantar();
        */
        
        Pessoa pessoa1 = new Pessoa("Douglas", 35, "douglas.camata@docente.senai.br");
       pessoa1.Cantar();
       pessoa1.Informacoes(); 

        Pessoa pessoa2 = new Pessoa("Ricardo", 34, "ricardo@docente.senai.br");
       pessoa2.Cantar();
       pessoa2.Informacoes(); 
       
    

    }
}
