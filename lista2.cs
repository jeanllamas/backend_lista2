using System;
using System.Linq;

namespace backend_lista2
{
    class lista2
    {
        static void Main(string[] args)
        {
            int ligado = 1; //"Liga" o programa
            do
            {
                Console.Clear();

                Console.WriteLine("Jean Augusto - Lista 2" + Environment.NewLine);
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine($"{i} - Exercício {i}");
                }
                Console.WriteLine(Environment.NewLine + "Sair - Encerrar programa");
                Console.WriteLine(Environment.NewLine + "Selecione um número para acessar o exercício (Ex.: '4' para exercício 4):");

                var entrada = Console.ReadLine();

                switch (entrada) //Encerra quando o usuário escolher a opção de sair
                {
                    case "sair":
                    case "Sair":
                        ligado = 0;
                        continue;
                }

                bool checagem = int.TryParse(entrada, out int num_exercicio); /*Retorna verdadeiro se a conversão da entrada para inteiro der certo
                                                                                e move o número correspondente ao exercício para uma int */

                switch (num_exercicio)
                {
                    //Se for um valor fora do limite ou não for um número, retorna uma mensagem de erro
                    case < 1 when checagem:
                    case > 15 when checagem:
                    default:
                        Console.WriteLine(Environment.NewLine + "Opção de exercício inválida. Tente novamente.");
                        break;

                    //Quando o valor estiver dentro do limite, segue normalmente
                    case >= 1 when checagem:
                    case <= 15 when checagem:
                        Console.Clear();
                        Exercicios(num_exercicio); //Encaminha para o exercício escolhido
                        break;
                }

                //Mensagem para retornar ou encerrar
                Console.WriteLine(Environment.NewLine + "Voltar ao início? (S/N)");
                var voltar = Console.ReadLine();

                switch (voltar)
                {
                    case "S":
                    case "s":
                        continue; //Mantém o programa "ligado"
                    default:
                        ligado = 0; //"Desliga" o programa
                        continue;
                }

            } while (ligado == 1);
        }

        static void Exercicios(int escolha)
        {
            switch(escolha)
            {
                case 1: //Exercício 1
                    {
                        Console.WriteLine("Exercício 1 - Soma de números pares e ímpares" + Environment.NewLine);

                        int numero = 0, soma_par = 0, soma_impar = 0;

                        List<int> pares = new List<int>();
                        List<int> impares = new List<int>();

                        while (numero <= 1000)
                        {
                            Console.Write("Digite um número:  ");
                            numero = Convert.ToInt32(Console.ReadLine());
                            Console.Write(Environment.NewLine);

                            if (numero % 2 == 0 && numero <= 1000)
                            {
                                pares.Add(numero);
                            }
                            else if (numero % 2 == 1 && numero <= 1000)
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
                        Console.WriteLine($"Soma de números ímpares: {soma_impar}");
                        break;
                    }

                case 2: //Exercício 2
                    {
                        Console.WriteLine("Exercício 2 - N números pares e ímpares" + Environment.NewLine);

                        int n, pares = 0, impares = 1;

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
                        break;
                    }

                case 3: //Exercício 3
                    {
                        Console.WriteLine("Exercício 3 - Produto dos números" + Environment.NewLine);

                        int numero = 1, produto = 1;

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
                        break;
                    }

                case 4: //Exercício 4
                    {
                        Console.WriteLine("Exercício 4 - Tabuada de 0 a 9" + Environment.NewLine);

                        int num;

                        Console.WriteLine("Digite um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(Environment.NewLine + $"Tabuada do {num}" + Environment.NewLine);
                        for (int i = 0; i <= 9; i++)
                        {
                            Console.WriteLine($"{num} * {i} = {num * i}");
                        }
                        break;
                    }

                case 5: //Exercício 5
                    {
                        Console.WriteLine("Exercício 5 - Maior e menor número" + Environment.NewLine);

                        int[] numeros = new int[15];
                        int maior, menor;

                        for (int i = 0; i < 15; i++) //Recebimento dos 15 valores
                        {
                            Console.Write($"Digite o {i + 1}º número: "); //i+1 para corrigir visualmente o 1º espaço da array numero[0]
                            numeros[i] = (Convert.ToInt32(Console.ReadLine()));
                        }

                        maior = numeros[0];
                        menor = numeros[0];

                        for (int i = 1; i < 15; i++) //Etapa de verificação do maior e menor número
                        {
                            if (numeros[i] > maior) //Atualiza qual é o maior e menor número conforme avança posições na array
                            {
                                maior = numeros[i];
                            }
                            else if (numeros[i] < menor)
                            {
                                menor = numeros[i];
                            }
                        }

                        Console.WriteLine(Environment.NewLine + $"O maior número digitado foi {maior} e o menor {menor}");
                        break;
                    }

                case 6: //Exercício 6
                    {
                        int idade = 0;
                        List<int> menores21 = new List<int>();
                        List<int> maiores50 = new List<int>();

                        Console.WriteLine("Exercício 6 - Pessoas com menos de 21 e mais de 50 anos" + Environment.NewLine);

                        do
                        {
                            Console.Write("Digite a idade de uma pessoa: ");
                            idade = Convert.ToInt32(Console.ReadLine());

                            if (idade < 21)
                            {
                                menores21.Add(idade);
                            }
                            else if (idade > 50)
                            {
                                maiores50.Add(idade);
                            }

                        } while (idade != -99);

                        Console.WriteLine(Environment.NewLine + "Total:");
                        Console.WriteLine($"Menos de 21 anos: {menores21.Count} pessoas");
                        Console.WriteLine($"Mais de 50 anos: {maiores50.Count} pessoas");

                        break;
                    }

                case 7: //Exercício 7
                    {
                        break;
                    }

                case 8: //Exercício 8
                    {
                        break;
                    }

                case 9: //Exercício 9
                    {
                        break;
                    }

                case 10: //Exercício 10
                    {
                        break;
                    }

                case 11: //Exercício 11
                    {
                        break;
                    }

                case 12: //Exercício 12
                    {
                        break;
                    }

                case 13: //Exercício 13
                    {
                        break;
                    }

                case 14: //Exercício 14
                    {
                        break;
                    }

                case 15: //Exercício 15
                    {
                        break;
                    }

            }
        }
    }
}