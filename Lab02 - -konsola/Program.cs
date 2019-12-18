#define Przyklad4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02____konsola
{
    class Program
    {
        static void Main(string[] args)
        {
#if (Przyklad1)
            String imie = "Piotr";
            String nazwisko = "Wardzyn";
            Console.WriteLine("Witam " + imie + " " + nazwisko);

            Console.WriteLine("Witaj {0} {1}", imie, nazwisko);
            Console.WriteLine($"Witam {imie} {nazwisko}");
#elif (Przyklad2)
            Console.Write("Podaj imie ");
            string JakisTekst;
            JakisTekst = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(JakisTekst);
#elif (Przyklad3)
            int liczba;
            Console.Write("Podaj liczbe: ");
            liczba = int.Parse(Console.ReadLine());
            Console.WriteLine($"Liczba to {liczba}");
#elif (Przyklad4)
            Console.WriteLine("pierwszy kom");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("drugi kom");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("trzeci kom");
            Console.ResetColor();
            Console.WriteLine("czwarty kom");
#endif
            Console.ReadKey();
        }
    }
}
