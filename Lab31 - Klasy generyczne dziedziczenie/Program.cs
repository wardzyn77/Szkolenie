using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31___Klasy_generyczne_dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            IntKalkulator ik = new IntKalkulator();
            Console.WriteLine(ik.Dodaj(3, 6));
            Console.WriteLine(ik.Odejmij(11, 4));

            dblKalkulator dk = new dblKalkulator();
            Console.WriteLine(dk.Dodaj(3.44, 6.22));
            Console.WriteLine(dk.Odejmij(11.33, 4.11));



            Console.ReadKey();
        }
    }
}
