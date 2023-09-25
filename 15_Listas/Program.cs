using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos à lista 
        listaNumeros.Add(10);  //Posição [0]
        listaNumeros.Add(20);  //Posição [1]
        listaNumeros.Add(45);  //Posição [2]

        //Acessando os dados da lista pelo indice
        Console.WriteLine(listaNumeros[2]);

        //Contagem de elementos
        Console.WriteLine($"Neste momento temos{listaNumeros.Count} elementos");

        listaNumeros.Add(55); // posição [3]
        Console.WriteLine($"Neste momento temos{listaNumeros.Count} elementos");


        /////////////////////////////////////////////


        List<string> listaNomes = new List<string>();
        listaNomes.Add("Lima");
        listaNomes.Add("Felipe");
        listaNomes.Add("Julio");
        Console.WriteLine(listaNomes[2]);
        Console.WriteLine($"Neste momento temos{listaNomes.Count} elementos");

        //Criando uma lista de números já atribuido valores
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elementos na lista números :{numeros.Count}");
        numeros.Remove(2); //Remover o elemento 2
        numeros.RemoveAt(1); //Remover o elemento no indice 1
        numeros.RemoveRange(2, 2); //Remove 2 elementos a partir do indice 2

        //Substituindo informação do item da lista
        numeros[0] = 100;

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        //Criando uma lista com objetos da classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adiconado um novo aluno à minha lista
        Aluno novoAluno = new Aluno("Pedro1", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //Exibindo lista de alunos
        Console.WriteLine("Lista Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine(($"{item.nome}.{item.idade}"));
        }

        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        //LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
                        .Where(aluno => aluno.idade == 17)
                        .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }

    }
}