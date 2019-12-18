using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18___Klasa_konstruktory__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Zwierze mucha = new Zwierze("mucha", 3, 13);
            mucha.OpiszKonsola();
            Console.WriteLine("------------------------------");
            Zwierze pies = new Zwierze("dog", 13);
            pies.OpiszKonsola();
            */
            Prostokat prost1 = new Prostokat(new Punkt(2, 2), 1, 3);
            prost1.ObliczProstokat();


            Console.ReadKey();
        }
    }
}
