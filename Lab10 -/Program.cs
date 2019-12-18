#define dowhile
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10__
{
    class Program
    {
        static void Main(string[] args)
        {
#if (For1)

            for (int i = 0; i < 10; i++)
			{
                Console.WriteLine(i);
			}
#elif (For2)
            List<int> lista = new List<int>()
            {
                44, 12, 33, 24
            };
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i} -> {lista[i]}");
            }
#elif (Foreach)
            foreach (var item in "szkolenie")
            {
                Console.WriteLine(item);
            }
            List<int> lista = new List<int>()
            {
                44, 12, 33, 24
            };
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
#elif (while)
            int licznik = 0;
            while (licznik < 10)
            {
                Console.WriteLine(licznik);
                licznik++;
            }
#elif (dowhile)
            int licznik = 0;
            do
            {
                Console.WriteLine(licznik);
                licznik++;
            } while (licznik < 10);
#endif
            Console.ReadKey();
        }
    }
}
