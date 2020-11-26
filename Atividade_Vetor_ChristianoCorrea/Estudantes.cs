namespace Aula13_VetoresPT2
{
    class Estudantes
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        // construtor
        public Estudantes(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return
                        Quarto + ": " +
                        Nome + ", " +
                        Email;
        }
    }
}
