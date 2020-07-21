using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            System.Console.WriteLine("Ordem crescente:");
            for (i = 1; i < 11; i++)
            {
                System.Console.WriteLine($"{i}");
            }

            System.Console.WriteLine("Ordem decrescente:");
            for (i = 10; i <= 1; i--)
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

         static void Exercise1(string[] args)
        {
        }

         static void Exercise2(string[] args)
        {
        }

         static void Exercise3(string[] args)
        {
        }
        static void Exercise4(string[] args)
        {
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
            string[] name = new string[5];
            int[] age = new int[5];
            int i;
            
            for (i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Informe o nome:");
                name[i] = System.Console.ReadLine();
                
                for (i = 0; i < 1 ; i++)
                {
                    System.Console.WriteLine("Informe o nome:");
                    age[i] = Convert.ToInt32(System.Console.ReadLine());
                }
            }

        }

        static void Exercise6(string[] args)
        {
            System.Console.WriteLine("1- Cadastrar candidato");
            System.Console.WriteLine("2- Votar");
            System.Console.WriteLine("3- Candidato vencedor");
            System.Console.WriteLine("Digite o modo escolhido:");
            var modo = Console.ReadLine();

            switch(modo)
            {
                case "1":
                Int32.Parse(modo);
                System.Console.WriteLine("Digite");
                break;

                case "2":
                break;

                case "3":
                break;

            }
        }
    
        static void Exercise7(string[] args)
        {

            System.Console.WriteLine("Há quantos anos a pessoa é fumante?");
            var anos = Console.ReadLine();
            Int32.Parse(anos);

            System.Console.WriteLine("Quantos cigarros o fumante fuma por dia?");
            var cigarros = Console.ReadLine();
            Int32.Parse(cigarros);

            System.Console.WriteLine("Qual o valor da carteira de cigarros consumida pelo fumante?");
            var valorCarteira = Console.ReadLine();
            Int32.Parse(valorCarteira);

        }

         static void Exercise8(string[] args)
        {
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
            // faltou info na questão.
        }

        static void Exercise13(string[] args)
        {
            // pulei
        }

        static void Exercise14(string[] args)
        {
            System.Console.WriteLine("Informe o primeiro número:");
            var a = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Informe o segundo número:");
            var b = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Informe o terceiro número:");
            var c = Convert.ToInt32(System.Console.ReadLine());
        }

        static void Exercise15(string[] args)
        {
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
    }
}
