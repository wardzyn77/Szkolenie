using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25___Klasy_zapieczetowane
{
    class KlasaPochodna : KlasaBazowa  
    {
        public override void Test()
        {
            base.Test();
            Console.WriteLine("Klasa Pochodna - metoda Test()");
        }
    }
}
