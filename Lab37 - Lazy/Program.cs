
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab37___Lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            Lazy<string> helloWorld = new Lazy<string>(() => "Witaj Swiecie");
            Console.WriteLine($"czy zmienna [helloWorld] zostala zainicjalizowana { helloWorld.IsValueCreated}");

            Console.WriteLine("=================");

            Console.WriteLine(helloWorld.Value);

            Console.WriteLine($"czy zmienna [helloWorld] zostala zainicjalizowana { helloWorld.IsValueCreated}");

            Console.ReadKey();

            Lazy<Samochod> samochod = new Lazy<Samochod>(() => new Samochod("BMW", 2000));

            Console.WriteLine($"czy zmienna [samochod] zostala zainicjalizowana { samochod.IsValueCreated}");

            Console.WriteLine(samochod.Value.marka);

            Console.WriteLine($"czy zmienna [samochod] zostala zainicjalizowana { samochod.IsValueCreated}");

            Console.ReadKey();



        }
    }
}