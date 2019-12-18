using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22__Klasy_abstrakcyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();
            samochod.Marka = "fiat";
            Console.WriteLine(samochod.Marka);
            samochod.PokazAuto();
            samochod.iloscKiero = 2;
        }
    }
}
