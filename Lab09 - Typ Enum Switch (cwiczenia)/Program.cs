using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09___Typ_Enum_Switch__cwiczenia_
{
    class Program
    {
        enum RodzajKawy
        {
            mala,
            srednia,
            duza
        }
        static void Main(string[] args)
        {
            decimal vCenaK;
            RodzajKawy RodzajKawy = RodzajKawy.duza;

            switch (RodzajKawy)
            {
                case RodzajKawy.mala:
                    vCenaK = 3;
                    break;
                case RodzajKawy.srednia:
                    vCenaK = 4.5m;
                    break;
                case RodzajKawy.duza:
                    vCenaK = 6;
                    break;
                default:
                    vCenaK = 0;
                    break;
            }
            Console.WriteLine($"Wybrana kawa to: {RodzajKawy}, Cena kawy: {vCenaK}");

            Console.ReadKey();
        }
    }
}
