using System;
using System.Linq;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise14();
        }

         static void Exercise1()
        {
            // teste executado
            int counter = 1;
            int decrement = 10;
            int counter2 = 1;

            Console.WriteLine("Ordem Crescente:");

            while (counter < 11)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("Ordem Decrescente:");

            while (decrement > 0)
            {
                Console.WriteLine(decrement);
                decrement--;
            }

            Console.WriteLine("Ordem Crescente de Pares:");

            while (counter2 < 11)
            {
                if (counter2 % 2 == 0)
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
        }

         static void Exercise2()
        {
            // teste executado
            int counter = 1;
            var soma = 0;

            Console.WriteLine("Lista");

            while (counter < 101)
            {
                soma += counter;
                counter++;
            }

            Console.WriteLine("Soma dos inteiros de 1 a 100:");
            Console.WriteLine(soma);
        }

         static void Exercise3()
        {
            // teste executado
            int counter = 0;

            Console.WriteLine("Ímpares menores que 200:");

            while (counter < 200)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }
        static void Exercise4()
        {
            // teste executado
            double sum = 0.0;
            double counter = 0.0;
        
            // roda infinitamente
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
        static void Exercise5()
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

        static void Exercise6()
        {
            // teste executado
            // string[] nomes = new string[2];
            // int counter1 = 0;
            // int counter2 = 0;
            // int i;

            // System.Console.WriteLine("Informe a senha para cadastrar os candidatos:");
            //  var senha = System.Console.ReadLine();

            // if (senha == "Pa$$w0rd")
            // {
            //     for (i = 0; i < 2; i++)
            //     {
            //         System.Console.WriteLine("Informe o nome do candidato:");
            //         nomes[i] = System.Console.ReadLine();
            //     }
            // }

            // System.Console.WriteLine("Para votar, informe o número do candidato:");
            // System.Console.WriteLine($"[1]{nomes[0]}  [2]{nomes[1]}");
            // var voto = System.Console.ReadLine();

            // if (voto == "1")
            // {
            //     counter1++;
            // }
            // else if (voto == "2")
            // {
            //     counter2++;
            // }
            // else
            // {
            //     System.Console.WriteLine("Número inválido");
            // }

            // if (counter1 > counter2)
            // {
            //     System.Console.WriteLine($"O candidato líder de votos é {nomes[0]}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"O candidato líder de votos é {nomes[1]}");
            // }

			const string registerMode = "1";
			const string votesMode = "2";
			const string resultMode = "3";

			// tupla
            var candidates = new (string name, int votes)[2];
			
			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a baixo:");
				System.Console.WriteLine($"{registerMode}) Cadastro de candidatos");
				System.Console.WriteLine($"{votesMode}) Votar");
				System.Console.WriteLine($"{resultMode}) Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == resultMode)
				{
					break;
				}

				if (mode == registerMode)
				{
					var password = "";
					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

                    for (int i = 0; i < candidates.Length; i++)
                    {                   
                        System.Console.WriteLine($"Digite o nome do candidato nº{i + 1}");
                        candidates[i].name = Console.ReadLine();
                    }
				}

				if (mode == votesMode)
				{
					System.Console.WriteLine($"Vote 1 para o candidato: {candidates[0].name} ou 2 para o candidato: {candidates[1].name}");
					
					var vote = Int32.Parse(Console.ReadLine());
					candidates[vote - 1].votes++;
				}
			}

			if (candidates[0].votes == candidates[1].votes)
			{
				System.Console.WriteLine("Segundo turno!");
			}
			else
			{
				var winner = candidates[0];
                for (int i = 1; i < candidates.Length; i++)
                {
                    var currentCandidate = candidates[i];
                    if (currentCandidate.votes > winner.votes)
                    {
                        winner = currentCandidate;
                    }
                }

				System.Console.WriteLine($"O vencedor é: {winner.name}");
				System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
			}
		}
    
        static void Exercise7()
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

         static void Exercise8()
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

        
         static void Exercise9()
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

            static void Exercise10()
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

        static void Exercise11()
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

        static void Exercise12()
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


        static void Exercise13()
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

        static void Exercise14()
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

        static void Exercise15()
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

         static void Exercise16()
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

        static void Exercise17()
        {
            // teste ok
            int i;
            int result;

            while (true)
            {
                System.Console.WriteLine("Informe um número:");
                var num = Convert.ToInt32(System.Console.ReadLine());

                if(num == -1)
                {
                    break;
                }

                for (i = 1; i < 11; i++)
                {
                    result = num * i;
                    System.Console.WriteLine($"{num} * {i} = {result}");
                }
            }
        }

        static void Exercise18()
        {
            // teste ok
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
