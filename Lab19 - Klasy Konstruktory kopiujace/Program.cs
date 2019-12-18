using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19___Klasy_Konstruktory_kopiujace
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod sam1 = new Samochod("Toy", 5);
            Samochod sam2 = new Samochod(sam1);

            Console.WriteLine(sam1.marka);
            Console.WriteLine(sam1.iloscDrzwi);
            Console.WriteLine("------------------");
            Console.WriteLine(sam2.marka);
            Console.WriteLine(sam2.iloscDrzwi);
            Console.WriteLine("---------ZMIANA DANYCH---------");

            sam2.marka = "ddd";
            sam1.iloscDrzwi = 7;        //przy przypisaniu sam3=sam1 i zmianie danych sam3 również zmienia sam1 !!!!!!
            Console.WriteLine(sam1.marka);
            Console.WriteLine(sam1.iloscDrzwi);
            Console.WriteLine("------------------");
            Console.WriteLine(sam2.marka);
            Console.WriteLine(sam2.iloscDrzwi);
            Console.WriteLine("------------------");



            Console.ReadKey();
        }
    }
}
