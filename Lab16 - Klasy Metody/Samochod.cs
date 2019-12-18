using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17___Klasy_Metody
{
    class Samochod
    {
        public string marka;
        public int rokProd;
        public int aktualnaPredkosc;
        public int maxPredkosc;

        public void PokazAuto()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka: {marka}{nl}Rok produkcji: {rokProd}{nl}Aktualna prędkość: {aktualnaPredkosc}{nl}Max prędkość: {maxPredkosc}");
        }
        public void Przyspiesz(int wartosc)
        {            
            aktualnaPredkosc += wartosc;
            if (aktualnaPredkosc > maxPredkosc)
                aktualnaPredkosc = maxPredkosc;
        }
        public void Zwolnij(int wartosc)
        {
            aktualnaPredkosc -= wartosc;
            if (aktualnaPredkosc < 0)
                aktualnaPredkosc = 0;
        }
    }
}
