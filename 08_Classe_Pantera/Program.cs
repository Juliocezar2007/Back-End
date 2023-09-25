
using Sesi.Model;

class Program
{
    public static void Main()
    {
        var pantera = new Pantera();
        pantera.nome = "pantera";
        pantera.tamanho = 2;
        pantera.peso = "35kg";
        pantera.cor ="rosa";
        pantera.especie = "terrestre";
        pantera.alimentacao = "carnes";
        
         pantera.caracteristica();
         pantera.correr();
         pantera.caçar();
         pantera.reproduzir();
    }
}