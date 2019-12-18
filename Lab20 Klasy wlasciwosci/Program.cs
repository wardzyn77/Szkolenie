using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Klasy_wlasciwosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Fia", 2020, 230);
            samochod.Marka = "jakis inny";  //ustawiłem w klasie i właściwosci set privet, wiec nie pozwala zmieniac
            Console.WriteLine(samochod.Marka);
            samochod.MaxPredkosc = 22;      //ustawiłem w klasie i właściwosci set privet, wiec nie pozwala zmieniac
            Console.ReadKey();
        }
    }
}
