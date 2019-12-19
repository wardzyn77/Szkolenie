using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab26___Klasy_zagniezdzone
{
    class Samochod
    {
        public  class Silnik
        {
            public int Moc { get; set; }

            public Silnik (int moc = 500)
            {
                Console.WriteLine("konstruktor silnika");
                Moc = moc;
            }
        }
        public  Silnik silnik;

        public int PokazMoc()
        {
            return silnik.Moc;
        }
        public Samochod ()
        {
            Console.WriteLine("konstruktor samochodu");
            silnik  = new Silnik();
            silnik.Moc = 700;
        }
    }
}
