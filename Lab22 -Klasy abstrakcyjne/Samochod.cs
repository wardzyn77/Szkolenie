using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22__Klasy_abstrakcyjne
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
        public override void Przyspiesz(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if (AktualnaPredkosc + wartosc <= MaxPredkosc)
                {
                    AktualnaPredkosc += wartosc;
                }
                else AktualnaPredkosc = MaxPredkosc;
            }
            else Console.WriteLine("Włącz najpierw silnik");
        }

        public override void Uruchom()
        {
            WlaczonySilnik = true;
        }

        public override void Zatrzymaj()
        {
            WlaczonySilnik = false;
            AktualnaPredkosc = 0;
        }

        public override void Zwolnij(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if (AktualnaPredkosc - wartosc >= 0)
                {
                    AktualnaPredkosc -= wartosc;
                }
                else AktualnaPredkosc = 0;
            }
            else Console.WriteLine("Włącz najpierw silnik");
        }
    }

}
