using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32___Interfejsy
{
    class Pojazd : IPojazd
    {
        public string Marka { get; set; }
        public int RokProdukcji { get; set; }
        public int AktualnaPredkosc { get; set; } = 0;
        public int MaksymalnaPredkosc { get; set; } = 200;
        public bool WlaczonySilnik { get; set; }

        public void Przyspiesz(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if (AktualnaPredkosc + wartosc <= MaksymalnaPredkosc)
                {
                    AktualnaPredkosc += wartosc;
                }
                else AktualnaPredkosc = MaksymalnaPredkosc;
            }
            else Console.WriteLine("Wlacz najpierw silnik");
        }

        public void Uruchom()
        {
            WlaczonySilnik = true;
        }

        public void Zatrzymaj()
        {
            WlaczonySilnik = false;
        }

        public void Zwolnij(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if (AktualnaPredkosc - wartosc >= 0)
                {
                    AktualnaPredkosc -= wartosc;
                }
                else AktualnaPredkosc = 0;
            }
            else Console.WriteLine("Wlacz najpierw silnik");
        }
    }
}