using System;
using System.Linq;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6-Leia um array A com 12 elementos. Após sua leitura, colocar os seus elementos em
            // ordem crescente. Depois ler um array B também com doze elementos, colocar os
            // elementos de B em ordem decrescente. Construir um array C, onde cada elemento de C é a
            // soma do elemento correspondente de A com b. Colocar em ordem crescente a matriz
            // C e apresentar os seus valores.

            int[] a = new int[12];
            int[] b = new int[12];
            var i = 0;

            System.Console.WriteLine("Ordem crescente do array A:");
            for (i = 0; i < 12; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(a);

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine(a[i]); 
            }

        }

         static void Exercise1(string[] args)
        {
            // teste executado
            int i;
            
            System.Console.WriteLine("Ordem crescente:");
            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"{i}");
            }

            System.Console.WriteLine("Ordem decrescente:");
            for (i = 10; i >= 1; i--)
            {
                System.Console.WriteLine($"{i}");
            }

            System.Console.WriteLine("Ordem crescente de pares:");
            for (i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                System.Console.WriteLine($"{i}");
            }
        }

         static void Exercise2(string[] args)
        {
            // teste executado
            int soma = 0;
            int i = 0;

            for (i = 0; i <= 100; i++)
            {
                soma = soma + i;
            }

            System.Console.WriteLine($"A soma de todos os inteiros de 1 a 100 é: {soma}");
        }

         static void Exercise3(string[] args)
        {
           // teste executado
           int i = 0;

            for (i = 0; i <= 200; i++) 
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine($"{i}");
                }
            }
        }
        static void Exercise4(string[] args)
        {
            // teste executado
            double sum = 0.0;
            double counter = 0.0;
        
            while (true)
            {
                System.Console.WriteLine("Digite a idade:");
                var result = Console.ReadLine();

                if (result == "0")
                {
                    break;
                }

                counter++;

                sum += Int32.Parse(result);
            }

            System.Console.WriteLine("A média da turma é:");
            System.Console.WriteLine(String.Format("{0:0.00}", sum / counter));

        }
        static void Exercise5(string[] args)
        {
            // teste executado
            string[] name = new string[5];
            int[] age = new int[5];
            int i;
            int counter = 0;
            double percentual;
            
            for (i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Informe o nome:");
                name[i] = System.Console.ReadLine();
                System.Console.WriteLine("Informe a idade:");
                age[i] = Convert.ToInt32(System.Console.ReadLine());

                if (age[i] >= 18 && age[i] <= 35)
                {
                    counter++;
                }
            }

            percentual = (counter * 100) / 5;
            System.Console.WriteLine($"O percentual de mulheres entre 18 e 35 anos é de: {percentual}%");

        }

        static void Exercise6(string[] args)
        {
            // teste executado
            string[] nomes = new string[2];
            int counter1 = 0;
            int counter2 = 0;
            int i;

            System.Console.WriteLine("Informe a senha para cadastrar os candidatos:");
             var senha = System.Console.ReadLine();

            if (senha == "Pa$$w0rd")
            {
                for (i = 0; i < 2; i++)
                {
                    System.Console.WriteLine("Informe o nome do candidato:");
                    nomes[i] = System.Console.ReadLine();
                }
            }

            System.Console.WriteLine("Para votar, informe o número do candidato:");
            System.Console.WriteLine($"[1]{nomes[0]}  [2]{nomes[1]}");
            var voto = System.Console.ReadLine();

            if (voto == "1")
            {
                counter1++;
            }
            else if (voto == "2")
            {
                counter2++;
            }
            else
            {
                System.Console.WriteLine("Número inválido");
            }

            if (counter1 > counter2)
            {
                System.Console.WriteLine($"O candidato líder de votos é {nomes[0]}");
            }
            else
            {
                System.Console.WriteLine($"O candidato líder de votos é {nomes[1]}");
            }

        }
    
        static void Exercise7(string[] args)
        {
            // teste executado
            double valorUn;
            double gasto;
            
            System.Console.WriteLine("Há quantos anos a pessoa é fumante?");
            var anos = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Quantos cigarros o fumante fuma por dia?");
            var cigarrosDia = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Qual o valor da carteira de cigarros consumida pelo fumante?");
            var valorCarteira = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Qual a quantidade de cigarros por carteira?");
            var cigarrosCarteira = Convert.ToDouble(System.Console.ReadLine());

            valorUn = valorCarteira / cigarrosCarteira;
            gasto = ((anos * 365) * cigarrosDia) * valorUn;

            System.Console.WriteLine($"O gasto total do fumante até agora foi de R${gasto.ToString("0.00")}");
        }

         static void Exercise8(string[] args)
        {
            // teste executado
            System.Console.WriteLine("Informe o valor de X:");
            var x = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Informe o valor de Y:");
            var y = Convert.ToInt32(System.Console.ReadLine());
            

            if (x % y == 0)
            {
                System.Console.WriteLine("X é múltiplo de Y.");
            }
            else
            {
                System.Console.WriteLine("X não é múltiplo de Y.");
            }

        }

        
         static void Exercise9(string[] args)
        {
            // teste executado
            System.Console.WriteLine("Informe o primeiro número:");
            var a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Informe o segundo número:");
            var b = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Informe o terceiro número:");
            var c = Convert.ToDouble(System.Console.ReadLine());

            if (b + c < a)
            {
                System.Console.WriteLine("Sim, o primeiro número é maior que a soma dos outros dois.");
            }
            else
            {
                System.Console.WriteLine("Não, o primeiro número não é maior que a soma dos outros dois.");
            }
        }

            static void Exercise10(string[] args)
        {
            // teste executado
            System.Console.WriteLine("Informe o primeiro número:");
            var a = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Informe o segundo número:");
            var b = Convert.ToDouble(System.Console.ReadLine());

            if (a == b)
            {
                System.Console.WriteLine("A = B");
            }
            else if (a > b)
            {
                System.Console.WriteLine($"O maior número é: {a}");
            }
            else
            {
                System.Console.WriteLine($"O maior número é: {b}");
            }
        }

        static void Exercise11(string[] args)
        {
            // teste executado
            int quociente = 0;
            
            System.Console.WriteLine("Informe o primeiro número:");
            var a = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Informe o segundo número:");
            var b = Convert.ToInt32(System.Console.ReadLine());

            if (b != 0)
            {
                quociente = a / b;
                System.Console.WriteLine($"O quociente é: {quociente}");
            }
            else
            {
                System.Console.WriteLine("Divisão por zero.");
            }
        }

        static void Exercise12(string[] args)
        {
            // teste executado
            int[] num = new int[4];
            int i = 0;
            int soma = 0;

            for (i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Informe um número:");
                num[i] = Convert.ToInt32(System.Console.ReadLine());

                if (num[i] % 2 == 0)
                {
                    soma = soma + num[i];
                }
            }

            System.Console.WriteLine($"A soma dos números pares é: {soma}");
        }


        static void Exercise13(string[] args)
        {
            // teste executado
            int maior = 0;
            int[] num = new int[10];
            int i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número:");
                num[i] = Convert.ToInt32(System.Console.ReadLine());

                if (num[i] > maior)
                {
                    maior = num[i];
                }
            }
            
            System.Console.WriteLine($"O maior número é {maior}.");

        }

        static void Exercise14(string[] args)
        {
            // teste executado
            int[] num = new int[3];

            System.Console.WriteLine("Informe o primeiro número:");
            num[0] = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Informe o segundo número:");
            num[1] = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Informe o terceiro número:");
            num[2] = Convert.ToInt32(System.Console.ReadLine());

            if (num[0] > num[1])
            {
                if (num[1] > num[2])
                {
                    System.Console.WriteLine($"{num[2]} {num[1]} {num[0]}");
                }
                else
                {
                    if (num[0] > num[2])
                    {
                        System.Console.WriteLine($"{num[1]} {num[2]} {num[0]}");
                    }
                    else
                    {
                        System.Console.WriteLine($"{num[1]} {num[0]} {num[2]}");
                    }
                }
            }
            else if (num[1] > num[2])
            {
            
                if (num[0] > num[2])
                {
                    System.Console.WriteLine($"{num[2]} {num[0]} {num[1]}");
                }
                else
                {
                    System.Console.WriteLine($"{num[0]} {num[2]} {num[1]}");
                }
                
            }
            else 
            {
                System.Console.WriteLine($"{num[0]} {num[1]} {num[2]}");
            }

        }

        static void Exercise15(string[] args)
        {
            // teste executado
            int i;
            var counter1 = 0;
            var counter2 = 0;

            for (i = 0; i < 10 ; i++)
            {
                System.Console.WriteLine("Informe um número:");
                var num = Convert.ToInt32(System.Console.ReadLine());

                if (num % 3 == 0)
                {
                    counter1++;
                }
                else if (num % 5 == 0)
                {
                    counter2++;
                }

            }

            System.Console.WriteLine($"{counter1} números são múltiplos de 3.");
            System.Console.WriteLine($"{counter2} números são múltiplos de 5.");

        }

         static void Exercise16(string[] args)
            {
                // teste executado
                double salarioliquido = 0;
                
                System.Console.WriteLine("Informe o salário bruto:");
                var salario = Convert.ToDouble(System.Console.ReadLine());

                if (salario > 600 && salario <= 1000)
                {
                    salarioliquido = salario - (salario * 0.2);
                }
                else if (salario > 1200 && salario <= 2000)
                {
                    salarioliquido = salario - (salario * 0.25);
                }
                else if (salario > 2000)
                {
                    salarioliquido = salario - (salario * 0.3);
                }
                
                System.Console.WriteLine($"O salário líquido será de: {salarioliquido}");
            }

        static void Exercise17(string[] args)
        {
            // teste executado
            int i;
            int result;

            System.Console.WriteLine("Informe um número:");
            var num = Convert.ToInt32(System.Console.ReadLine());

            for (i = 1; i < 11; i++)
            {
                result = num * i;
                System.Console.WriteLine($"{num} * {i} = {result}");
            }
        }

        static void Exercise18(string[] args)
        {
            // teste executado
            double price = 0;
            double total = 0;
            
            System.Console.WriteLine("Informe a quantidade de maçãs compradas:");
            var apple = Convert.ToInt32(System.Console.ReadLine());

            if (apple < 12)
            {
                price = 1.30;
            }
            else if (apple >= 12)
            {
                price = 1;
            }

            total = apple + price;
            System.Console.WriteLine($"O valor total da compra será de: R${total.ToString("0.00")}");
        }

        static void Array1(string[] args)
        {
            // teste executado
            int[] a = new int[15];
            int[] b = new int[15];
            int[] c = new int[15];
            int i = 0;

            for (i = 0; i < 15; i++)
            {
                System.Console.WriteLine("Informe um valor para A:");
                a[i] = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Informe um valor para B:");
                b[i] = Convert.ToInt32(System.Console.ReadLine());
                c[i] = a[i] - b[i];
                System.Console.WriteLine($"Valor de C: {c[i]}");
            }
        }

        static void Array2(string[] args)
        {
            // teste executado
            int[] num = new int[10];
            var i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Lista decrescente dos inteiros:");

            for (i = 9; i >= 0; i--)
            {
                System.Console.WriteLine($"{num[i]}");
            }
        }

        static void Array3(string[] args)
        {
            // teste executado
            int[] a = new int[10];
            var i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Informe um número inteiro a ser pesquisado:");
            var num = Convert.ToInt32(Console.ReadLine());

            if (a.Contains(num))
            {
                System.Console.WriteLine("O número existe no array.");
            }
            else
            {
                System.Console.WriteLine("Número inexistente.");
            }

        }

        static void Array4(string[] args)
        {
            // pesquisar comparação
            int[] a = new int[10];
            int[] b = new int[10];
            var i = 0;

            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Informe um número inteiro:");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        static void Array5(string[] args)
        {
            // teste executado
            int[] a = new int [15];
            var soma = 0;
            var i = 0;
            var media = 0;
            var counter = 0;
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;

            for (i = 0; i < 15; i++)
            {
                System.Console.WriteLine("Informe um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + a[i];
                counter++;
            }

            media = soma / counter;

            for (i = 0; i < 15; i++)
            {
                if (a[i] > media)
                {
                    counter2++;
                }
                else if (a[i] == media)
                {
                    counter3++;
                }
                else
                {
                    counter4++;
                }
            }

           System.Console.WriteLine($"A média final é {counter2}.");
           System.Console.WriteLine($"{counter2} estão acima da média.");
           System.Console.WriteLine($"{counter3} estão na média.");
           System.Console.WriteLine($"{counter4} estão abaixo da média.");

        }

        static void Array6(string[] args)
        {
        }
    }
}
