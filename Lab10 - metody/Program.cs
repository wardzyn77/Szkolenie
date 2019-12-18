using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10___metody
{
    class Program
    {
        //NazwaMetody z wielkich liter
        //Nazwa zmiennej z malej litery
        static string PobierzTekst(string tekst)
        {
            Console.WriteLine($"{tekst}");
            return Console.ReadLine();
        }
        static string ZwrocInicjaly(string imie, string nazwisko)
        {
            return imie[0] + "." + nazwisko[0];
        }
        static void DrukujDane(string imie, string nazwisko)
        {
            Console.WriteLine($"Nazywasz się {imie} {nazwisko}");
        }
        static void DrukujLiczbe(int liczba1, int liczba2)      //można wiele razy definiować tą samą metodę, pod warunkiem, że ma inne ilości parametrów lub typy
        {
            Console.WriteLine($"{liczba1} {liczba2}");
        }
        static void DrukujLiczbe(int liczba1, int liczba2, int liczba3)
        {
            Console.WriteLine($"{liczba1} {liczba2}");
        }
        static void DrukujLiczbe(double liczba1, double liczba2)
        {
            Console.WriteLine($"{liczba1} {liczba2}");
        }
        static int ZwrocDlugoscTekstu (string tekst)
        {
            return tekst.Length;
        }
        static void ZwrocDlugoscTekstu(string tekst, out int dlugosc)  //raczej nie wykorzystane
        {
            dlugosc = tekst.Length;
        }
        static void Powieksz(string tekst)
        {
            tekst = tekst.ToUpper();    //tu działamy tylko na kopii wartości, zatem w miejscu gdzie było wywołane nie zmieniły sie dane. Stąd należy wywołać przez ref, jak poniżej
        }
        static void Powieksz(ref string tekst)
        {
            tekst = tekst.ToUpper();
        }

        static void Main(string[] args)
        {
            //int liczbaDl;
            //string imie = PobierzTekst("Podaj imię");
            //string nazwisko = PobierzTekst("Podaj nazwisko");
            //DrukujDane(imie, nazwisko);
            //Console.WriteLine($"Imie: {imie}, nazwisko: {nazwisko}, inicjały: {ZwrocInicjaly(imie, nazwisko)}");
            //Console.Write ("Imie i nazw  ");
            //DrukujLiczbe(1, 2);
            //DrukujLiczbe(1, 2, 3);
            //DrukujLiczbe(1.2, 2.0);
            //int liczbaInt = ZwrocDlugoscTekstu("asdzxc sfe 12sa");
            //ZwrocDlugoscTekstu("asdzxc sfe 12sa", out liczbaDl);        //zmienną out zadeklarowałem wcześniej
            //ZwrocDlugoscTekstu("asdzxc sfe 12sa", out int liczbaDlug);  //ale mogę i tak
            //Console.WriteLine(liczbaInt);
            string nazwa = "sdf sd sd fsdfsee esfsd";
            Console.WriteLine(nazwa);
            Powieksz(nazwa);            //tu NIE zadziała powiększenie, bo metoda (opis wyżej) działa na kopii danych
            Console.WriteLine(nazwa);
            Powieksz(ref nazwa);        //a tu zadziała
            Console.WriteLine(nazwa);

            Console.ReadKey();        
        }
    }
}
