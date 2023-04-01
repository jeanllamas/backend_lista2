using System;
using System.Diagnostics.Metrics;
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
                        ligado = 0; //"Desliga" o programa
                        continue;
                }

                bool checagem = int.TryParse(entrada, out int num_exercicio); /*Retorna verdadeiro se a conversão da entrada para inteiro der certo
                                                                                e move o número correspondente ao exercício para uma int */
                if (checagem)
                {
                    if (num_exercicio >= 1 && num_exercicio <= 15)
                    {
                        Console.Clear();
                        Exercicios(num_exercicio); //Encaminha para o exercício escolhido
                    }
                    else
                    {
                        Console.WriteLine(Environment.NewLine + $"Não há Exercício {num_exercicio}. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Opção inválida. Tente novamente.");
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
                        Console.WriteLine("Exercício 7 - Solicitar número" + Environment.NewLine);

                        int numero;

                        do
                        {
                            Console.Write("Digite um número: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero < 1 || numero > 4)
                            {
                                Console.WriteLine(Environment.NewLine + "entrada inválida" + Environment.NewLine);
                            }
                            else
                            {
                                Console.WriteLine(Environment.NewLine + numero);
                            }
                        } while (numero < 1 || numero > 4);
                        break;
                    }

                case 8: //Exercício 8
                    {
                        Console.WriteLine("Exercício 8 - Nome de trás pra frente" + Environment.NewLine);

                        string nome, invertido;

                        Console.Write("Digite um nome: ");
                        nome = Console.ReadLine();

                        invertido = new string(nome.Reverse().ToArray());
                        Console.Write(Environment.NewLine + $"Nome invertido: {invertido}" + Environment.NewLine);
                        break;
                    }

                case 9: //Exercício 9
                    {
                        Console.WriteLine("Exercício 9 - Números ímpares até 100" + Environment.NewLine);

                        Console.WriteLine("Os números ímpares de 1 até 100 são:");
                        for (int impares = 1; impares < 100; impares += 2)
                        {
                            Console.Write(impares + " ");

                            switch (impares)
                            {
                                case 19:
                                case 39:
                                case 59:
                                case 79:
                                case 99:
                                    Console.Write(Environment.NewLine);
                                    break;
                            }
                        }
                        break;
                    }

                case 10: //Exercício 10
                    {
                        Console.WriteLine("Exercício 10 - Média de notas de uma turma" + Environment.NewLine);

                        float qtd_estudantes, soma_notas = 0;

                        Console.Write("Quantos estudantes há na turma? ");
                        qtd_estudantes = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("");

                        for (int i = 1; i <= qtd_estudantes; i++)
                        {
                            Console.Write($"Insira a nota do {i}º estudante: ");
                            soma_notas += Convert.ToSingle(Console.ReadLine());
                        }

                        Console.WriteLine(Environment.NewLine + $"A média da turma é {(soma_notas / qtd_estudantes):0.000}");
                        break;
                    }

                case 11: //Exercício 11
                    {
                        Console.WriteLine("Exercício 11 - Maior número" + Environment.NewLine);

                        int i = 0, maior = 0;
                        int[] numeros = new int[10]; 

                        while (i < 10)
                        {
                            Console.Write($"Digite o {i + 1}º número: ");
                            numeros[i] = Convert.ToInt32(Console.ReadLine());
                            
                            if (numeros[i] > maior)
                            {
                                maior = numeros[i];
                            }

                            i++;
                        }

                        Console.WriteLine(Environment.NewLine + $"Maior número: {maior}");
                        break;
                    }

                case 12: //Exercício 12
                    {
                        Console.WriteLine("Exercício 12 - 1 a 100 com for, while e do-while" + Environment.NewLine);

                        int i = 1;

                        Console.WriteLine("1 a 100 com for");
                        for (i = 1; i <= 100; i++)
                        {
                            Console.Write(i + " ");
                            switch (i)
                            {
                                case 25:
                                case 50:
                                case 75:
                                case 100:
                                    Console.Write(Environment.NewLine);
                                    break;
                            }
                        }
                        i = 1;

                        Console.WriteLine(Environment.NewLine + "1 a 100 com while");
                        while (i <= 100)
                        {
                            Console.Write(i + " ");
                            switch (i)
                            {
                                case 25:
                                case 50:
                                case 75:
                                case 100:
                                    Console.Write(Environment.NewLine);
                                    break;
                            }
                            i++;
                        }
                        i = 1;

                        Console.WriteLine(Environment.NewLine + "1 a 100 com do-while");
                        do
                        {
                            Console.Write(i + " ");
                            switch (i)
                            {
                                case 25:
                                case 50:
                                case 75:
                                case 100:
                                    Console.Write(Environment.NewLine);
                                    break;
                            }
                            i++;
                        } while (i <= 100);
                        break;
                    }

                case 13: //Exercício 13
                    {
                        Console.WriteLine("Exercício 13 - Quadrado, cubo e raiz quadrada" + Environment.NewLine);

                        double numero, quadrado, cubo, raiz;

                        do
                        {
                            Console.Write("Digite um número: ");
                            numero = Convert.ToDouble(Console.ReadLine());

                            if (numero > 0)
                            {
                                quadrado = Math.Pow(numero, 2);
                                cubo = Math.Pow(numero, 3);
                                raiz = Math.Sqrt(numero);

                                Console.WriteLine($"{numero}² = {(quadrado):0.00}");
                                Console.WriteLine($"{numero}³ = {(cubo):0.00}");
                                Console.WriteLine($"√{numero} = {(raiz):0.00}" + Environment.NewLine);
                            }
                        } while (numero > 0);
                        break;
                    }

                case 14: //Exercício 14
                    {
                        int repetir = 1;
                        do
                        {
                            Console.WriteLine("Exercício 14 - Conversor de velocidade" + Environment.NewLine);

                            Console.WriteLine("1 - km/h para m/s");
                            Console.WriteLine("2 - m/s para km/h");
                            Console.Write(Environment.NewLine + "Selecione uma opção: ");
                            var entrada = Console.ReadLine();

                            bool checagem = int.TryParse(entrada, out int tipo);

                            if (checagem)
                            {
                                switch (tipo)
                                {
                                    case 1: //km/h para m/s
                                        {
                                            Console.WriteLine(Environment.NewLine + "Converter km/h para m/s");

                                            Console.Write("Velocidade em km/h: ");
                                            float kmh = Convert.ToSingle(Console.ReadLine());

                                            Console.WriteLine(Environment.NewLine + $"{kmh} km/h equivalem a {(kmh / 3.6):0.00} m/s");
                                            break;
                                        }

                                    case 2: //m/s para km/h
                                        {
                                            Console.WriteLine(Environment.NewLine + "Converter m/s para km/h");

                                            Console.Write("Velocidade em m/s: ");
                                            float ms = Convert.ToSingle(Console.ReadLine());

                                            Console.WriteLine(Environment.NewLine + $"{ms} m/s equivalem a {(ms * 3.6):0.00} km/h");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine(Environment.NewLine + $"Não há opção {tipo}. Tente novamente.");
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                Console.WriteLine(Environment.NewLine + "Opção inválida. Tente novamente.");
                            }

                            Console.WriteLine(Environment.NewLine + "Fazer outra conversão? (S/N)");
                            var voltar = Console.ReadLine();

                            switch (voltar)
                            {
                                case "S":
                                case "s":
                                    Console.Clear();
                                    continue;
                                default:
                                    repetir = 0;
                                    continue;
                            }
                        } while (repetir == 1);
                        break;
                    }

                case 15: //Exercício 15
                    {
                        Console.WriteLine("Exercício 15 - Salário atual do funcionário" + Environment.NewLine);

                        double salario = 2000.0;
                        int ano_atual = DateTime.Now.Year;

                        salario *= 1.015;

                        double aumento = 30;

                        Console.WriteLine("Salário em");
                        for (int ano = 2007; ano <= ano_atual; ano++)
                        {
                            salario += aumento*2;
                            aumento *= 2;
                            Console.WriteLine($"{ano} com R${aumento:0.00} de aumento: R${salario:0.00}");
                        }
                        break;
                    }
            }
        }
    }
}