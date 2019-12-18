using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16___Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod();     //stworzony obiekt samochod1 o klasie samochod (wczesniej utworzona klasa)
            samochod1.marka = "Fiat";
            samochod1.rokProd = 2000;
            samochod1.maxPredkosc = 200;
            Console.WriteLine($"Marka: {samochod1.marka}\n{samochod1.rokProd}\n{samochod1.aktualnaPredkosc}\n{samochod1.maxPredkosc}");


            Console.ReadKey();
        }
    }
}
