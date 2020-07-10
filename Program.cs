using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // const string myText = "exemplo";

            // var currentDate = DateTime.Now;

            // var price = 4.099;

           Console.WriteLine("Qual a sua idade?");

           var result = Console.ReadLine();


           int userAge = Int32.Parse(result);

            if (userAge > 15 && userAge < 51) 
           {
                Console.WriteLine ("Sim, você tem idade para o Entra21!");
           }
        //    else if (userAge == 14 || userAge == 15)
        //    {
        //        Console.WriteLine ("Você não tem idade para o Entra21, mas pode ser menor aprendiz!");
        //    }
           else
           {
               Console.WriteLine ("Você não tem idade para o Entra21!");
           }
           
        Console.WriteLine ("Só isso e mais nada!");
       }
   }
}
