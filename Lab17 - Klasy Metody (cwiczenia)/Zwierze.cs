using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17___Klasy_Metody__cwiczenia_
{
    class Zwierze
    {
        public string nazwa;
        public int iloscOczu;
        public int iloscNog;

        public string Opisz()
        {
            string nl;
            nl = Environment.NewLine;
            return $"Nazwa zwierzaka: + {nazwa} + {nl} + Ilość oczu: + {iloscOczu} + {nl} + Ilość nóg:  + {iloscNog}";            
        }
        public void OpiszKonsola()
        {
            Console.WriteLine(Opisz());
        }
    }
}
