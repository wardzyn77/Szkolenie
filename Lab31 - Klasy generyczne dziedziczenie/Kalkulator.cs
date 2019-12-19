using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31___Klasy_generyczne_dziedziczenie
{
    abstract class Kalkulator<T>
    {
        public abstract T Dodaj(T x, T y);

        public abstract T Odejmij(T x, T y);
    }
   
}
