using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_39___delegaty
{
    class Program
    {
        static void KonsolaA(string x)
        {
            Console.WriteLine($"KonsolaAAA {x}");
        }
        static void KonsolaB(string x)
        {
            Console.WriteLine($"KonsolaBBB {x}");
        }
        static string Dodaj(int x, int y)
        {
            return $"Działanie Dodaj";// {x} + {y}";
        }
        static string Odejmij(int x, int y)
        {
            return $"Działanie Odejmij {x} - {y}";
        }
        delegate void Drukuj(string x);
        delegate void Licz(int x, int y);
        static void Main(string[] args)
        {
            Drukuj drukuj1 = KonsolaA;
            drukuj1("jakiś tekst");
            Console.WriteLine("++++++++");
            drukuj1 += KonsolaB;
            drukuj1("jakiś tekst");
            Console.WriteLine("++++++++");
            Licz licz1 = Dodaj;
            Console.WriteLine(licz1(1,4));
            licz1 += Odejmij;
            Console.WriteLine(licz1(1, 4));


            Console.ReadKey();
        }
    }
}
