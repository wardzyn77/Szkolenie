using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42___Petla_Wspolbierzna
{
    class Program
    {
        static void Main(string[] args)
        {
            //w petli sa wykonywane wspolbierznie, co powoduje losowe pokazywanie wynikow!!!!
            Parallel.For(1, 200, (n) =>
           {
               if ((n % 8) == 0)
               {
                   Console.WriteLine($"liczba {n} jest podzielna przez 8");
               }
           });
            Console.ReadKey();
        }
    }
}
