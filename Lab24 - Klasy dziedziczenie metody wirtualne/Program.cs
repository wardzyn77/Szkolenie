using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24___Klasy_dziedziczenie_metody_wirtualne
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2D a = new Punkt2D(1,2);
            Console.WriteLine(a.PokazWspolrzedne());
            Punkt3D b = new Punkt3D(10, 20, 30);
            Console.WriteLine(b.PokazWspolrzedne());
            Punkt2D c = new Punkt3D(100, 200, 300);
            Console.WriteLine(c.PokazWspolrzedne());



            Console.ReadKey();
        }
    }
}
