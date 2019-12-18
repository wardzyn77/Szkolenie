#define Cwiczenie3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03___Typy_danych__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
#if (Cwiczenie1)
            DateTime vdtData = DateTime.Today;
            Console.WriteLine($"Data: {vdtData}");
            Console.WriteLine($"Dzien w Roku: {vdtData.DayOfYear}");
            Console.WriteLine($"Czy Rok jest przestępny: {DateTime.IsLeapYear(vdtData.Year)}");

#elif (Cwiczenie2)
            DateTime vdtData = DateTime.Today;
            Console.WriteLine($"Dzien jutro: {vdtData.AddDays (1).DayOfWeek}");
#elif (Cwiczenie21)
            string vstrOsoba;
            Console.WriteLine("Podaj swoje imie i nazwisko");
            vstrOsoba = Console.ReadLine();            
            Console.WriteLine($"Pierwsze 6 znakow WIELKA litera: {vstrOsoba.Substring(0,6)}");
            vstrOsoba = vstrOsoba.ToUpper();
            Console.WriteLine($"Pierwsze 6 znakow WIELKA litera: {vstrOsoba.Substring(0, 6)}");
           
#elif (Cwiczenie3)
            //przy dzieleniu przez 0 ale w zmiennych float, to nie wywali błędu, NIE będzie znał wyniku
            //natomiast przy zmiennych typu int krzyrzknie, że nie można dzielić przez 0
            float vflLiczba1 = 1.43f;
            float vflLiczba2 = 0;
            Console.WriteLine(vflLiczba1/ vflLiczba2);


            Console.ReadKey();
#endif
        }
    }
}
