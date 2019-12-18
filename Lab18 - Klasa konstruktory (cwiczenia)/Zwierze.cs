using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18___Klasa_konstruktory__cwiczenia_
{
    class Zwierze
    {
        public string nazwa;
        public int iloscOczu;
        public int iloscNog;

        public Zwierze(string nazwa, int iloscOczu, int iloscNog)
        {
            this.nazwa = nazwa;
            this.iloscNog = iloscNog;
            this.iloscOczu = iloscOczu;
        }

        public Zwierze(string nazwa, int iloscNog) : this (nazwa, 2, iloscNog)
        {
            this.nazwa = nazwa;
            this.iloscNog = iloscNog;            
        }
        public string Opisz()
        {
            string nl;
            nl = Environment.NewLine;
            return $"Nazwa zwierzaka: {nazwa}{nl}Ilość oczu: {iloscOczu}{nl}Ilość nóg: {iloscNog}";            
        }
        public void OpiszKonsola()
        {
            Console.WriteLine(Opisz());
        }
    }
}
