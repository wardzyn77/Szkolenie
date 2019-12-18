using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19___Klasy_Konstruktory_kopiujace
{
    class Samochod
    {
        public string marka;
        public int iloscDrzwi;
        public Samochod(string marka, int iloscDrzwi)
        {
            this.marka = marka;
            this.iloscDrzwi = iloscDrzwi;
        }
        public Samochod(Samochod samochod)
        {
            //dzięki takiej metodzie przypisanie sam3=sam1 będzie kopiowane, oczywiście przy zastosowaniu metody 
            this.marka = samochod.marka;
            this.iloscDrzwi = samochod.iloscDrzwi;
            Console.WriteLine("Konstruktor kopiujący");
        }
    }
}
