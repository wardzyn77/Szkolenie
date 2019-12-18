using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17___Klasy_Metody__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Zwierze mucha = new Zwierze();
            mucha.nazwa = "mucha ta";
            mucha.iloscOczu = 3;
            mucha.iloscNog = 12;
            tekst = mucha.Opisz;
            mucha.OpiszKonsola();

            Console.ReadKey();
        }
    }
}
