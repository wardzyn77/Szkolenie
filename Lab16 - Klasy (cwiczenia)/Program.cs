using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16___Klasy__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze pies = new Zwierze();
            pies.nazwa = "dog";
            pies.iloscNog = 4;
            pies.iloscOczu = 2;

            Zwierze mucha = new Zwierze();
            mucha.nazwa = "mucha";
            mucha.iloscOczu = 3;
            mucha.iloscNog = 6;

            Zwierze pajak = new Zwierze();
            pajak.nazwa = "pająk";
            pajak.iloscNog = 12;
            pajak.iloscOczu = 2;

            //foreach (var item in Zwierze) //nie wiem jak
            {
                Console.WriteLine($"Nazwa zwierzaka: {pies.nazwa}");
                
            }

            Console.ReadKey();
        }
    }
}
