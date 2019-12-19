using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31___Klasy_generyczne_dziedziczenie
{
    class dblKalkulator : Kalkulator<double>
    {
        public override double Dodaj(double x, double y)
        {
            return x + y;
        }

        public override double Odejmij(double x, double y)
        {
            return x - y;
        }
    }
}
