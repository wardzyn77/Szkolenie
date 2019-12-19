using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28___Klasy_konstruktory_statyczne
{
    class Powitanie
    {
        public static string wiadomosc;

        static Powitanie()      //wywolany zawsze, ale tylko raz
        {
            Console.WriteLine("konstruktor statyczny");
            DateTime teraz = DateTime.Now;
            if (teraz.Hour < 18)
            {
                wiadomosc = "dzień dobry";
            }
            else wiadomosc = "dobry wieczór";
        }
        public Powitanie ()     //wywola sie zawsze przy tworzeniu obiektu
        {
            Console.WriteLine("konstruktor ");
        }
    }
}
