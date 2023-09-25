//Sempre que fomos utilizar bibliotecas ou classes já criadas 
//importamos ela com o using
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //Criando uma variável aluno1 e instanciando da classe Aluno
        //Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Dolglas";
        aluno1.idade = 35;
        aluno1.turma = "2º EM";
        //Chamando o método da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.Justificarfaltas(8);
        aluno1.ResumirFaltas();


        //Criando uma variável aluno2 e instanciando da classe Aluno
        //Ou seja, estamos criando nosso objeto
        var aluno2 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno3
        aluno2.nome = "Ricardo";
        aluno2.idade = 34;
        aluno2.turma = "3º EM";
        //Chamando o método da classe Aluno
        aluno2.Apresentar();
        aluno2.ResumirFaltas();
        aluno2.AdicionarFaltas(10);
        aluno2.ResumirFaltas();
        aluno2.AdicionarFaltas(7);
        aluno2.ResumirFaltas();



        //Criando uma variável aluno3 e instanciando da classe Aluno
        //Ou seja, estamos criando nosso objeto
        var aluno3 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno3
        aluno3.nome = "Jair";
        aluno3.idade = 33;
        aluno3.turma = "1º EM";
        //Chamando o método da classe Aluno
        aluno3.Apresentar();
        aluno3.ResumirFaltas();
        aluno3.AdicionarFaltas(10);
        aluno3.ResumirFaltas();
        aluno3.AdicionarFaltas(7);
        aluno3.ResumirFaltas();

    }
}