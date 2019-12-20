using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab40___Wyrazenia_Lambda
{
    class Program
    {
        delegate int Power(int i);
        delegate void PrintHello(string name);
        static void Main(string[] args)
        {
            List<Pracownik> listaPracownikow = new List<Pracownik>()
            {
                new Pracownik { Id = 1, Name = "Paw" },
                new Pracownik { Id = 2, Name = "Pawel" },
                new Pracownik { Id = 3, Name = "Piotr" },
                new Pracownik { Id = 4, Name = "Dorota" }
            };
            //Mozna tak:
            //Pracownik pracownik1 = new Pracownik();
            //foreach (var p in listaPracownikow)
            //{
            //    if (p.Id==3)
            //    {
            //        pracownik1 = p;
            //    }
            //}
            //Albo tak:
            //Pracownik pracownik1 = listaPracownikow.Find(p => p.Id == 3);
            //Console.WriteLine($"{pracownik1.Id} {pracownik1.Name}");
            //=> to wyrazenie lambda
            Power power1 = x => x * x;
            Console.WriteLine(power1(4));
            //
            PrintHello printHello1 = name => { string text = "witaj" + name; Console.WriteLine(text); };
            printHello1("Kubus dd");
            //
            Func<int, int> kwadrat = x => x * x;
            Console.WriteLine(kwadrat(16));
            //
            Func<string> powitaj = () => "cos ma wyjsc";
            Console.WriteLine(powitaj());
            //
            Func<int, int, int> prostokat = (x, y) => x * y;
            Console.WriteLine(prostokat(16,3));
            //

            Console.ReadKey();
        }
    }
}
