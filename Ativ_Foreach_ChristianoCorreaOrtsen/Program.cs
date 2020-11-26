using System;

namespace Ativ_Foreach_ChristianoCorreaOrtsen
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            int[] valores = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Insira um valor inteiro: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Valores Lidos: ");

            foreach (int i in valores)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // 2

            string[] nomes = new string[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Insira um nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Nomes Lidos: ");

            foreach (string i in nomes)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

        }
    }
}
