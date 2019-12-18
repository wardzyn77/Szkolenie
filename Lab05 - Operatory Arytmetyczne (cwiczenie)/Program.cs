#define Cwicz1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05___Operatory_Arytmetyczne__cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {
#if (Cwicz0)
            double vWzrost = 1.8;
            int vWaga = 90;
            double vBMI;
            vBMI = (System.Math.Pow(vWzrost, 2));
            vBMI = vWaga / vBMI;
            Console.WriteLine(vBMI);
#elif (Cwicz1)
            double vPole, vObwod;
            string vBok;
            Console.WriteLine("Podaj dlugosc boku kwadratu");
            vBok = Console.ReadLine();
            vPole = System.Math.Pow (Convert.ToDouble(vBok),2);
            vPole = Convert.ToDouble (vBok) * Convert.ToDouble(vBok);
            vObwod = (Convert.ToDouble(vBok)) * 4;
            Console.WriteLine($"Pole kwadratu: {vPole} , obwód {vObwod}");
#endif
            Console.ReadKey();
        }
    }
}
