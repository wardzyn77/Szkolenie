using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22__Klasy_abstrakcyjne
{
    abstract class Pojazd       
        //abstract powoduje, że klasa nie jest wywolywalna, nie mozna utworzyc obiektu tej klasy, moze byc dziedziczona dla innych klas
    {
        protected string marka;
        protected int rokProd;
        protected int aktualnaPredkosc;
        protected int maxPredkosc;
        private bool wlaczonySilnik;

        public string Marka { get => marka; set => marka = value; }
        public int RokProd { get => rokProd; set => rokProd = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaxPredkosc { get => maxPredkosc; set => maxPredkosc = value; }
        protected bool WlaczonySilnik { get => wlaczonySilnik; set => wlaczonySilnik = value; }

        public void PokazPojazd()
        {
            Console.WriteLine($"Aktualna prędkość Pojazdu: {AktualnaPredkosc}");
        }
        public abstract void Przyspiesz(int wartosc);
        //w związku z tym, ze klasa jest abstrakcyjna to możemy ustawić, że każda dziedzicząca klasa będzie musiała mieć daną metodę i w swoim kodzie opisać szczegóły tej metody (tu Przyspiesz)
        public abstract void Zwolnij(int wartosc);
        public abstract void Uruchom();
        public abstract void Zatrzymaj();
    }
}
