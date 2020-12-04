using System;
using System.Collections.Generic;

namespace Aula16_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> livros = new List<string>();
            Console.WriteLine("Digite o nome de um livro: ");
            string livro = Console.ReadLine();
            livros.Add(livro);

            livros.Add("O Pequeno Principe");
            livros.Add("Dom Quixote");
            livros.Add("A Divina Comedia");
            livros.Add("As Viagens de Gulliver");

            livros.Insert(1, "Guerra e Paz");
            livros.Insert(2, "A Montanha Magica");
            livros.Insert(3, "Hamlet");
            livros.Insert(4, "Arte da Guerra");
            livros.Insert(5, "As Tres Irmãs");


            Console.Clear();
            Console.WriteLine("Lista de Livros: ");
            Console.WriteLine();

            foreach (string biblioteca in livros)
            {
                Console.WriteLine(biblioteca);
            }

            //contagem valores lista
            Console.WriteLine();
            Console.WriteLine("Numero de livros: " + livros.Count);

            //encontrar na lista pela primeira letra
            string a = livros.Find(x => x[0] == 'G');
            Console.WriteLine("O livro que começa com G é: " + a);

            //encontrar ultimo
            string b = livros.FindLast(x => x[0] == 'D');
            Console.WriteLine("Ultimo livro que começa com D: " + b);

            //encontrar a primeira posicao que satisfaca um predicado
            int p = livros.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeiro livro que começa com A esta na posicao : " + p);


            //encontrar a ultima posicao que satisfaca um predicado
            int p2 = livros.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultimo livro que começa com A esta na posicao : " + p2);

            //filtrar lista
            Console.WriteLine();
            List<string> livros2 = livros.FindAll(x => x.Length >= 10);
            Console.WriteLine("Livros na lista que possuem mais de 10 letras:");
            foreach(string nomes in livros2)
            {
                Console.WriteLine(nomes);
            }

            // removr itens
            livros.Remove("Guerra e Paz");
            Console.WriteLine("Livro Guerra e Paz Removido da lista");

            //limpar lista
            livros.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("Removidos todos os livros que começam com a Letra A");

            //remover em posicao especifica
            livros.RemoveAt(0);
            Console.WriteLine("Livro na Posicao 1 foi removido");

            //remover elementods de uma faixa
            livros.RemoveRange(1, 4);
            Console.WriteLine("Livros nas posicoes de 2 a 5 foram removidos");
        }
    }
}
