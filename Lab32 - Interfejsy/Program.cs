using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32___Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojazd pojazd = new Pojazd();
            Console.WriteLine(pojazd.AktualnaPredkosc);
            pojazd.Przyspiesz(10);
            pojazd.Uruchom();
            pojazd.Przyspiesz(10);
            Console.WriteLine(pojazd.AktualnaPredkosc);

            Console.ReadKey();
        }
    }
}