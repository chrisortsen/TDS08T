using System;
using System.Collections.Generic;
using System.Linq;

namespace SA02_ChristianoCorreaOrtsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Receitas v = new Receitas();

            List<Receitas> receitas = new List<Receitas>();
            int x = 0;
        Menu:

            Console.WriteLine("1 - Adicionar nova Receita");
            Console.WriteLine("2 - Editar receita");
            Console.WriteLine("3 - Excluir receita");
            Console.WriteLine("4 - Listar todas as Receitas");
            Console.WriteLine("5 - Listar Receitas por dificuldade");
            Console.WriteLine("6 - Listar Receitas por categoria");
            Console.WriteLine("7 - Listar Receitas por tempo de preparação");
            Console.WriteLine();
            Console.Write("Escolha uma das opções do menu: ");
            int menu = int.Parse(Console.ReadLine());
            int escolha = 0;
            Console.Clear();
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Insira o nome da receita: ");
                    receitas.Add(new Receitas());
                    receitas[x].codreceita = x + 1;
                    receitas[x].nome = Console.ReadLine();
                    Console.WriteLine("Insira o tempo de preparo em minutos: ");
                    receitas[x].tempopreparacao = int.Parse(Console.ReadLine());
                    Console.WriteLine("1 - Fácil");
                    Console.WriteLine("2 - Médio");
                    Console.WriteLine("3 - Avançado");
                    Console.WriteLine("Selecione o grau de dificuldade: ");
                    escolha = int.Parse(Console.ReadLine());
                    if (escolha == 1)
                    {
                        receitas[x].dificuldade = "Fácil";
                        receitas[x].lvl = 1;
                    }
                    if (escolha == 2)
                    {
                        receitas[x].dificuldade = "Médio";
                        receitas[x].lvl = 2;
                    }
                    if (escolha == 3)
                    {
                        receitas[x].dificuldade = "Avançado";
                        receitas[x].lvl = 3;
                    }
                    if (escolha > 3 || escolha < 1)
                    {
                        Console.WriteLine("Opção Invalida");
                    }
                    Console.WriteLine("Insira o numero de pessoas que a receita serve: ");

                    receitas[x].servenumero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a categoria da receita (1 Carne, 2 Peixe, 3 Marisco, 4 Pastelaria, 5 Sobremesas, etc): ");
                    escolha = 0;
                    escolha = int.Parse(Console.ReadLine());
                    if (escolha == 1)
                    {
                        receitas[x].categoria = "Carne";
                        receitas[x].genero = 1;
                    }
                    if (escolha == 2)
                    {
                        receitas[x].categoria = "Peixe";
                        receitas[x].genero = 2;
                    }
                    if (escolha == 3)
                    {
                        receitas[x].categoria = "Marisco";
                        receitas[x].genero = 3;
                    }
                    if (escolha == 4)
                    {
                        receitas[x].categoria = "Pastelaria";
                        receitas[x].genero = 4;
                    }
                    if (escolha == 5)
                    {
                        receitas[x].categoria = "Sobremesa";
                        receitas[x].genero = 5;
                    }

                    Console.WriteLine("Insira o modo de preparo/descrição da receita: ");

                    receitas[x].descricao = Console.ReadLine();
                    x++;
                    Console.Clear();
                    goto Menu;

                case 2:
                    foreach (var item in receitas)
                    {
                        Console.WriteLine("COD.: " + item.codreceita + " Nome: " + item.nome);
                        //   Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    Console.Write("Insira o CODIGO da receita que deseja excluir, caso queira voltar direto ao menu principal digite 0: ");
                    escolha = 0;
                    escolha = int.Parse(Console.ReadLine());
                    if (escolha == 0)
                    {
                        goto Menu;
                    }
                    else
                    {
                        receitas.RemoveAt(escolha - 1);


                        Console.WriteLine("Insira o nome da receita: ");
                        receitas.Add(new Receitas());
                        receitas[escolha - 1].codreceita = escolha;
                        receitas[escolha - 1].nome = Console.ReadLine();
                        Console.WriteLine("Insira o tempo de preparo em minutos: ");
                        receitas[escolha - 1].tempopreparacao = int.Parse(Console.ReadLine());
                        Console.WriteLine("1 - Fácil");
                        Console.WriteLine("2 - Médio");
                        Console.WriteLine("3 - Avançado");
                        Console.WriteLine("Selecione o grau de dificuldade: ");

                        int opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            receitas[escolha - 1].dificuldade = "Fácil";
                            receitas[escolha - 1].lvl = 1;
                        }
                        if (opcao == 2)
                        {
                            receitas[escolha - 1].dificuldade = "Médio";
                            receitas[escolha - 1].lvl = 2;
                        }
                        if (opcao == 3)
                        {
                            receitas[escolha - 1].dificuldade = "Avançado";
                            receitas[escolha - 1].lvl = 3;
                        }
                        if (opcao > 3 || opcao < 1)
                        {
                            Console.WriteLine("Opção Invalida");
                        }
                        Console.WriteLine("Insira o numero de pessoas que a receita serve: ");

                        receitas[escolha - 1].servenumero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira a categoria da receita (1 Carne, 2 Peixe, 3 Marisco, 4 Pastelaria, 5 Sobremesas, etc): ");
                        opcao = 0;
                        opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            receitas[escolha - 1].categoria = "Carne";
                            receitas[escolha - 1].genero = 1;
                        }
                        if (opcao == 2)
                        {
                            receitas[escolha - 1].categoria = "Peixe";
                            receitas[escolha - 1].genero = 2;
                        }
                        if (opcao == 3)
                        {
                            receitas[escolha - 1].categoria = "Marisco";
                            receitas[escolha - 1].genero = 3;
                        }
                        if (opcao == 4)
                        {
                            receitas[escolha - 1].categoria = "Pastelaria";
                            receitas[escolha - 1].genero = 4;
                        }
                        if (opcao == 5)
                        {
                            receitas[escolha - 1].categoria = "Sobremesa";
                            receitas[escolha - 1].genero = 5;
                        }

                        Console.WriteLine("Insira o modo de preparo/descrição da receita: ");

                        receitas[escolha - 1].descricao = Console.ReadLine();

                    }

                    goto Menu;

                case 3:
                    foreach (var item in receitas)
                    {
                        Console.WriteLine("COD.: " + item.codreceita + " Nome: " + item.nome);
                        //   Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    Console.Write("Insira o CODIGO da receita que deseja excluir, caso queira voltar direto ao menu principal digite 0: ");
                    escolha = 0;
                    escolha = int.Parse(Console.ReadLine());
                    if (escolha == 0)
                    {
                        goto Menu;
                    }
                    else
                    {
                        receitas.RemoveAt(escolha - 1);
                    }
                    goto Menu;
                case 4:

                    receitas.Sort();
                    foreach (var item in receitas)
                    {
                        Console.WriteLine("COD.: " + item.codreceita + " Nome: " + item.nome);
                        //   Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    Console.Write("Voltar para o menu = 0");
                    escolha = int.Parse(Console.ReadLine());
                    goto Menu;

                case 5:
                    IEnumerable<Receitas> nivel = receitas.OrderBy(dific => dific.lvl);
                    foreach (var item in nivel)
                    {
                        Console.WriteLine("COD.: " + item.codreceita + " Nome: " + item.nome);
                        //   Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    Console.Write("Voltar para o menu = 0");
                    escolha = int.Parse(Console.ReadLine());
                    goto Menu;

                case 6:
                    IEnumerable<Receitas> cat = receitas.OrderBy(categ => categ.genero);
                    foreach (var item in cat)
                    {
                        Console.WriteLine("COD.: " + item.codreceita + " Nome: " + item.nome);
                        //   Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    Console.Write("Voltar para o menu = 0");
                    escolha = int.Parse(Console.ReadLine());
                    goto Menu;

                case 7:
                    IEnumerable<Receitas> tempopreparo = receitas.OrderBy(temp => temp.tempopreparacao);
                    foreach (var item in tempopreparo)
                    {
                        Console.WriteLine("COD.: " + item.codreceita + " Nome: " + item.nome);
                        //   Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    Console.Write("Voltar para o menu = 0");
                    escolha = int.Parse(Console.ReadLine());
                    goto Menu;







            }
        }
    }
}
