namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe pessoa
        private string nome { get; set; }
        private int idade { get; set;}	
        private string email { get; set; }
        private int anoNascimento { get; set; }
        
        //Método construtor da classe pessoa

        public Pessoa (string nomePessoa,int idadePessoa,string emailpessoa)
        {
            
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailpessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }


        //Método da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

         public void Informacoes()
        {
            Console.WriteLine($"{nome} tem o email {email}, nasceu em {anoNascimento} e tem {idade} anos");
        }
    }

}