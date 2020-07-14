using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new string[5];
            var age = new string[5];
            var counter1 = 0;
            var counter2 = 0;

            System.Console.WriteLine("Informe o");




        }
        static void Exercise1(string[] args)
        {
            int i;

            for (i = 1;i <= 10;i++)
            {
                System.Console.WriteLine(i);
            }
            for (i = 10;i >= 1;i--)
            {
                System.Console.WriteLine(i);
            }
            for (i = 1;i <= 10;i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

        }
        static void Exercise2(string[] args)
        {
          var soma = 0;
          var i = 0;

          for (i = 1;i <= 100;i++)
          {
              soma = soma + i;
          }
          System.Console.WriteLine($"Soma = {soma}");
        
        }
        
        static void Exercise3(string[] args)
        {
            var i = 0;

            for (i = 1;i <= 200;i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
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

   }
}
