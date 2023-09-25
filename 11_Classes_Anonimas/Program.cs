public class Program
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição )
        var pessoa1 = new {
            nome = "João",
            idade = 17,
            email = "maria@aluno.senai.br"
        };
        var pessoa2 = new {
            nome = "Maria",
              idade = 17,
            email = "maria@aluno.senai.br"
        };

        //pessoa1.nome = "Douglas";

        //Criar 2 objetos de classe anonima de carro

         var carro1 = new {
            marca = "Ford",
            ano = "2020",
            modelo = "Ranger"
           
        };
        var carro2 = new {
            marca = "Fiat",
            ano = 2000,
            modelo = "Uno"
        };

        Console.WriteLine($" A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($" A pessoa2 é {pessoa2.nome} e tem o email {pessoa2.email} ");

        Console.WriteLine($"O carro é da marca {carro1.marca} do ano {carro1.ano}, no modelo {carro1.modelo}");
        Console.WriteLine($"O carro é da marca {carro2.marca} do ano {carro2.ano}, no modelo {carro2.modelo}");

         
    }
}
