using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab26___Klasy_zagniezdzone
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();
            Console.WriteLine(samochod.PokazMoc());

            samochod.silnik = new Samochod.Silnik();    //dostanie domyślną
            samochod.silnik = new Samochod.Silnik(10);    //dostanie 10
            Console.WriteLine(samochod.PokazMoc());


            Console.ReadKey();
        }
    }
}
