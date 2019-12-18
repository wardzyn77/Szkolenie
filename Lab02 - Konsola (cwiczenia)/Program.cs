using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02___Konsola__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* definiujemy 2 zmienne, string i int
             * Write - bez przejscia do nowego wiersza
             * WriteLine - po wypisaniu do nowego wiersza
             * analogicznie Read
            */
            string Imie;
            int liczba;
            Console.Write("Podaj imie ");
            Imie = Console.ReadLine();
            Console.WriteLine("Podaj swoj wiek ");
            liczba = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Twoje imie to {Imie}, a Twoj wiek to {liczba}");
            Console.ReadKey();
        }
    }
}
