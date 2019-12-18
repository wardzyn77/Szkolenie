using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21___Klasy_dziedziczenie
{
    class Pojazd
    {
        private string marka;
        private int rokProd;
        private int aktualnaPredkosc;
        private int maxPredkosc;

        public string Marka { get => marka; set => marka = value; }
        public int RokProd { get => rokProd; set => rokProd = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaxPredkosc { get => maxPredkosc; set => maxPredkosc = value; }
    }
}
