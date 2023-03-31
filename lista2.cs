using System;
using System.Linq;

namespace backend_lista2
{
    class lista2
    {
        static void Main(string[] args)
        {
        inicio:
            int resposta = 0;
            do
            {
                Console.Clear();
                resposta = 0;
                int escolha;

                Console.WriteLine("Jean Augusto - Lista 2" + Environment.NewLine);
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine($"{i} - Exercício {i}");
                }
                Console.WriteLine(Environment.NewLine + "Sair - Encerrar programa");
                Console.WriteLine(Environment.NewLine + "Selecione um número para ver o exercício (Ex.: '4' para exercício 4):");
                string verifica = Console.ReadLine();

                //Etapa de verificação de escolha
                if (verifica == "Sair" || verifica == "sair")
                {
                    continue; //Sai do do-while encerrando o programa
                }
                else if ((verifica.All(Char.IsLetter))) //Verifica se a string contém letra
                {
                    goto inicio; //Se houver alguma letra no lugar de um número, exceto as palavras de saída, volta para o começo
                }
                else if (!(int.Parse(verifica) >= 1 && int.Parse(verifica) <= 10)) //Verifica se não é menor que 1 e maior que 10
                {
                    goto inicio; //Se for um número que não está entre 1 a 10, volta para o começo
                }
                else
                {
                    escolha = int.Parse(verifica); //Prossegue com a opção válida escolhida
                }
                Console.Clear();

                //Exercício 1
                if (escolha == 1)
                {
                    Exercicio1();
                }

                //Exercício 2
                else if (escolha == 2)
                {
                    Exercicio2();
                }

                //Exercício 3
                else if (escolha == 3)
                {
                    Exercicio3();
                }

                //Exercício 4
                else if (escolha == 4)
                {
                    Exercicio4();
                }

                //Exercício 5
                else if (escolha == 5)
                {
                    Exercicio5();
                }

                //Exercício 6
                else if (escolha == 6)
                {
                    Exercicio6();
                }

                //Exercício 7
                else if (escolha == 7)
                {
                    Exercicio7();
                }

                //Exercício 8
                else if (escolha == 8)
                {
                    Exercicio8();
                }

                //Exercício 9
                else if (escolha == 9)
                {
                    Exercicio9();
                }

                //Exercício 10
                else if (escolha == 10)
                {
                    Exercicio10();
                }

                //Exercício 11
                else if (escolha == 11)
                {
                    Exercicio11();
                }

                //Exercício 12
                else if (escolha == 12)
                {
                    Exercicio12();
                }

                //Exercício 13
                else if (escolha == 13)
                {
                    Exercicio13();
                }

                //Exercício 14
                else if (escolha == 14)
                {
                    Exercicio14();
                }

                //Exercício 15
                else if (escolha == 15)
                {
                    Exercicio15();
                }

                //Mensagem para retornar ou encerrar
                Console.WriteLine(Environment.NewLine + "Voltar ao início? (S/N)");
                string encerrar = Console.ReadLine();
                if (encerrar != "S" && encerrar != "s")
                {
                    continue;
                }
                else { resposta = 1; }

            } while (resposta != 0);
        }

        static void Exercicio1()
        {
            int numero = 0;
            int soma_par = 0;
            int soma_impar = 0;
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            
            Console.WriteLine("Exercício 1 - Soma de números pares e ímpares" + Environment.NewLine);

            while (numero <= 1000)
            {
                Console.Write("Digite um número:  ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.Write(Environment.NewLine);

                if (numero % 2 == 0 && numero <= 1000)
                {
                    pares.Add(numero);
                }
                else if(numero % 2 == 1 && numero <= 1000)
                {
                    impares.Add(numero);
                }
            }
            foreach (int par in pares)
            {
                soma_par += par;
            }
            foreach (int impar in impares)
            {
                soma_impar += impar;
            }
            Console.WriteLine($"Soma de números pares: {soma_par}" + Environment.NewLine);
            Console.WriteLine($"Soma de números pares: {soma_impar}");
        }

        static void Exercicio2()
        {
            int n, pares = 0, impares = 1;

            Console.WriteLine("Exercício 2 - N números pares e ímpares" + Environment.NewLine);

            Console.Write("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + $"Primeiros {n} números pares");
            for (int i = 0; i < n; i++)
            {
                Console.Write(pares + " ");
                pares += 2;
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine + $"Primeiros {n} números ímpares");
            for (int i = 0; i < n; i++)
            {
                Console.Write(impares + " ");
                impares += 2;
            }

            Console.WriteLine();
        }

        static void Exercicio3()
        {
            int numero = 1, produto = 1;

            Console.WriteLine("Exercício 3 - Produto dos números" + Environment.NewLine);

            while (numero != 0)
            {
                Console.Write("Digite um número:  ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    produto *= numero;
                    Console.WriteLine(produto + Environment.NewLine);
                }
            }
        }

        static void Exercicio4()
        {
            int num;

            Console.WriteLine("Exercício 4 - Tabuada de 0 a 9" + Environment.NewLine);

            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + $"Tabuada do {num}");
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        static void Exercicio5()
        {
            Console.WriteLine("Exercício 5 - Maior e menor número" + Environment.NewLine);
        }

        static void Exercicio6()
        {
            
        }

        static void Exercicio7()
        {
        }

        static void Exercicio8()
        {
            
        }

        static void Exercicio9()
        {
            
        }

        static void Exercicio10()
        {

        }
        static void Exercicio11()
        {

        }
        static void Exercicio12()
        {

        }
        static void Exercicio13()
        {

        }
        static void Exercicio14()
        {

        }
        static void Exercicio15()
        {

        }

    }
}