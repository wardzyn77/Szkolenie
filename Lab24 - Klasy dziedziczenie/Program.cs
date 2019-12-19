using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24___Klasy_dziedziczenie
{
    class Program
    {
        static void Wyswietl(Punkt2D p)
        {
            if (p is Punkt3D)
            {
                Console.WriteLine($"Wyswietl: {((Punkt3D)p).PokazWspolrzedne()}");
            }
            else
                Console.WriteLine($"Wyswietl222: {p.PokazWspolrzedne()}");
        }
        static void Main(string[] args)
        {
            Punkt2D p2d = new Punkt2D(2, 5);
            //Console.WriteLine($"Punkt 2d: {p2d.PokazWspolrzedne()}");
            Punkt3D p3d = new Punkt3D(2, 5, 11);
            //Console.WriteLine($"Punkt 3d: {p3d.PokazWspolrzedne()}");
            Punkt2D p2d_2 = new Punkt3D(10, 20, 30);    // do opakowania mogącego pomieścić 2 wartosci przypisalismy cos co ma szerszy zakres.
            //dzieki temu, ze Punkt3D jest dzieckiem i dziedziczy po Punkt2D działa poniższe
            //Opakowanie nazwaZmiennej = w_coWrzucic 
            //Console.WriteLine($"Punkt p2d_2: {p2d_2.PokazWspolrzedne()}");
            //dzieki temu, ze Punkt3D jest dzieckiem i dziedziczy po Punkt2D działa poniższe
            //Console.WriteLine($"Punkt p2d_2: {((Punkt3D)p2d_2).PokazWspolrzedne()}");
            //Punkt3D p3d_2 =(Punkt3D) new Punkt2D(50, 100);                    //wywali błąd przy kompilacji
            Punkt3D p3d3 = (Punkt3D)p2d_2;      //ominelismy powyzszy blad rzutowania w ten sposob
            Console.WriteLine($"Punkt p3d_3: {p3d3.PokazWspolrzedne()}");  
            //Wyswietl(p2d);
            //Wyswietl(p3d);
            Wyswietl(p2d_2);
            //Wyswietl(p3d_2);
            Punkt3D p3d2 = p2d as Punkt3D;
            if (p3d2 ==null)
            {
                Console.WriteLine(p2d.PokazWspolrzedne());
            }
            else Console.WriteLine(p3d2.PokazWspolrzedne());

            Console.ReadKey();
        }
    }
}
