using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29___Klasy_generyczne
{
    class Generyczna<TypGeneryczny>
    {
        TypGeneryczny nazwaZmiennejTypuGenerycznego;

        public TypGeneryczny ZwrocWartosc()
        {
            return nazwaZmiennejTypuGenerycznego;
        }

        public void NadajWartosc(TypGeneryczny nazwaParTypuGenerycznego)
        {
            nazwaZmiennejTypuGenerycznego = nazwaParTypuGenerycznego;
        }
    }
}
