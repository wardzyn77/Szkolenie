using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Klasy_wlasciwosci__cwiczenia_
{
    class Zwierze
    {
        private string nazwa;
        public int iloscOczu;
        //private int iloscNog;

        //public - 'wszyscy' widzą
        //private - tylko w obrębie klasy
        //protect - w obrębie klasy i klasy dziedziczące

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int IloscOczu { get => iloscOczu;private set => iloscOczu = value; }
        public int IloscNog { get; set; }

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
