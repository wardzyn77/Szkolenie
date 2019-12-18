using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18___Klasa_konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod sam1 = new Samochod("Toy", 2018, 220);
            sam1.PokazAuto();
            Console.WriteLine("-------------------");
            Samochod sam2 = new Samochod("Toy", 2018);
            Console.WriteLine("-------------------");
            sam2.PokazAuto();
            Console.WriteLine("-------------------");

            Console.ReadKey();
        }
    }
}
