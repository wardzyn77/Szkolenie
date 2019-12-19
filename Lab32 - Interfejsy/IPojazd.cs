using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32___Interfejsy
{
    interface IPojazd
    {
        string Marka { get; set; }
        void Uruchom();
        void Zatrzymaj();
        void Przyspiesz(int wartosc);
        void Zwolnij(int wartosc);

    }
}