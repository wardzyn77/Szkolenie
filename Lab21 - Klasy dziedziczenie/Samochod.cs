using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21___Klasy_dziedziczenie
{
    class Samochod : Pojazd 
    {
        public int iloscKiero;
        //klasa Samochod odziedziczyla wszystko po klasie Pojazd
        public void PokazAuto()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka: {Marka}{nl}Rok produkcji: {RokProd}{nl}Aktualna prędkość: {AktualnaPredkosc}{nl}Max prędkość: {MaxPredkosc}");
        }
        
    }

}
