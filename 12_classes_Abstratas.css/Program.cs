//Classe pai que sera herdado pelo filho - superClasse
abstract  class Animal
{
    public string cor { get; set; }

    public  virtual void Emitirsom()
    {
        Console.WriteLine("Animal emitido som");
    }
}
//Classe filha que herdará da classe Animal
//Receberá todos os atributos e métodos sa superClasse
class Cachorro : Animal
{
    public string tipoPelo { get; set; }
    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo");
    }
}

class Gato : Animal
{

    public override void Emitirsom()
    {
        Console.WriteLine($"O gato está miando");
    }
}

class program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal ();
        animalGenerico.Emitirsom();

        
        Cachorro meuCachorro = new Cachorro ();
        meuCachorro.cor = "caramelo";
        meuCachorro.Emitirsom ();
        meuCachorro.Latir();


        Gato meuGato = new Gato ();
        meuGato.Emitirsom();
    }
}