
namespace Sesi.Model
{
    public class Pantera
    {
       
        public string nome {get; set;}
        public int tamanho { get; set;}
        public string peso { get; set;}
        public string cor { get; set;}
        public string especie { get; set;}
        public string alimentacao { get; set;}

        private int nrFaltas {get; set;}
        public void caracteristica()
        
        {
            Console.WriteLine($"Olá, eu sou a {nome}, eu tenho {tamanho} de altura, peso {peso},minha cor é {cor},e me alimento de{alimentacao}");
        }

        public void correr()
        {
           Console.WriteLine($"{nome} esta correndo");
        }

        public void caçar()
        {
            Console.WriteLine($"{nome} esta caçando");
        }
        public void reproduzir()
        {
            Console.WriteLine($"{nome} esta reproduzindo");
        }

    }
}