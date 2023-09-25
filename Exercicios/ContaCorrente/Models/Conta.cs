namespace conta
{
    public class corrente
    {
        private string titular { get; set; }
        private decimal saldo { get; set; } =  0;


        public corrente(string titularCorrente)
        {

            this.titular = titularCorrente;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo é de {saldo}");

        }
        public void Depositar (decimal valor)
        {
            Console.WriteLine($"Deposite o valor");
            saldo += valor;
        }

        public void SacarSaldo(decimal valordosaque)
        {
            if (valordosaque> saldo)
            {
                Console.WriteLine ($"infelizmente você não pode sacar");
            }
            else{
                Console.WriteLine ($"Você retirou {valordosaque} da sua conta");
                saldo -= valordosaque;
            }
        }
    } 
}
