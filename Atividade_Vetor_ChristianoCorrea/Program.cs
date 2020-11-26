using System;
using System.Globalization;

namespace Aula13_VetoresPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            // sintaxe do vetor
            // tipo[] nomeDoVetor = new tipo[tamanho]
            Estudantes[] estudante = new Estudantes[n];
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Insira o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email do estudante: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o numero do quarto desejado: ");
                int quarto = int.Parse(Console.ReadLine());
                estudante[quarto] = new Estudantes(nome, email, quarto);
                Console.WriteLine();
            }
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i+1) +": ");
                Console.WriteLine("Nome: " + estudante[i].Nome);
                Console.WriteLine("Email: " + estudante[i].Email);
                Console.WriteLine("Quarto: " + estudante[i].Quarto);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < n; i++)
            {
                if(estudante[i] != null)
                Console.WriteLine(estudante[i].Quarto + ": " + estudante[i].Nome + ", " + estudante[i].Email);
            }
        }
    }
}
