using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17___Klasy_Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod();     //stworzony obiekt samochod1 o klasie samochod (wczesniej utworzona klasa)
            samochod1.marka = "Fiat";
            samochod1.rokProd = 2000;
            samochod1.maxPredkosc = 200;

            samochod1.PokazAuto();
            samochod1.Przyspiesz(1000);     //dzieki zapisom w metodzie klasy przyspieszy tylko do max samochodu
            samochod1.PokazAuto();

            samochod1.Zwolnij (110);        //dzieki zapisom w metodzie klasy zwolni tylko do 0
            samochod1.PokazAuto();


            Console.ReadKey();
        }
    }
}
