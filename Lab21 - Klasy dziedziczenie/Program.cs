using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21___Klasy_dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();
            samochod.Marka = "sssas";
            Console.WriteLine(samochod.Marka);
            samochod.PokazAuto();
            samochod.iloscKiero = 2;

            Console.ReadKey();
        }
    }
}
