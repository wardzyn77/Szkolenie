using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Klasy_wlasciwosci
{
    class Samochod
    {
        private string marka;
        private int rokProd;
        private int aktualnaPredkosc;
        private int maxPredkosc;

        public string Marka         
        {
            //przypisanie własciwosci dla pola
            //tak raczej NIE robimy 
            get { return marka; } 
            private set { marka = value; } 
        }
        //lepiej zrobić właściwości jak poniżej, ale też jest lepsze rozwiązanie
        //tak czy inaczej warto wówczas ukryć pola (NIE public tylko private
        public int RokProdukcji { get => rokProd; set => rokProd = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaxPredkosc { get => maxPredkosc; private  set => maxPredkosc = value; }
        public Samochod(string marka, int rokProdukcji, int maxPredkosc)     
        {
            //definujemy konstruktor, dzięki temu można wywołać metodę przypisując wartości
            this.marka = marka;
            this.rokProd = rokProdukcji;
            this.maxPredkosc = maxPredkosc;
            Console.WriteLine("Wywołany konstruktor 3 parametrowy");       //dodatkowe
        }
        public Samochod()       //przeciążając w ten sposób mogę wywołać później utworzenie metody, bez przypisywania wartości
        {
            Console.WriteLine("Wywołany konstruktor 3 parametrowy");       //dodatkowe
        }
        public Samochod(string marka)       //tutaj kolejnym przeciążeniem dodaje tylko wartość do 1 parametru
        {
            this.marka = marka;
            Console.WriteLine("Wywołany konstruktor 1 parametrowy");       //dodatkowe
        }
        public Samochod(string marka, int rokProdukcji) : this(marka, rokProdukcji, 200)
        {
            //konstruktor 2 parametrowy, ale odwołuje się do utworzonego wyżej konstruktora 3 paramtrowego przekazując mu tylko 2 parametry z wywołania, oraz trzeci defaultowy - jak wyżej =200
            Console.WriteLine("Został wywołany konstruktor pochodny");
        }
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
