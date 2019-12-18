#define Cw3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09___Petle__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
#if (Cw1)
            int Liczba;
            Console.WriteLine("Podaj liczbę");
            Liczba =Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < Liczba + 1; i = i + 2)
            { //i=i mod 2
                Console.WriteLine(i);
                //if (i/2)
                //{
                //    Console.WriteLine(i);
                //}
#elif (Cw2)
            int vLitery, vCyfry, vBiale;
            string Slowo;
            char znak;
            Console.WriteLine("Podaj ciąg znaków");
            Slowo = Console.ReadLine();
            
                foreach (var znak in Slowo)
                {
                    if (char.IsWhiteSpace(znak))
                        vBiale++;
                    if (char.IsLetter(znak))
                        vLitery++;
                    if (char.IsNumber(znak))
                        vCyfry++;
                }
            string NewL = Environment.NewLine;
                Console.WriteLine($"Ilość Liczb: {vCyfry}NewL Ilość pustych: {vBiale}");
#elif (Cw3)             
            //czy podana liczba jest liczbą pierwszą?
            int Liczba, reszta;
            Console.WriteLine("Podaj liczbę");
            Liczba = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Liczba; i++)
            {
                if (Liczba % i !=0)
                {
                    continue; //podnosi licznik i goni dalej, bez wykonywania reszty, od początku
                }
                else if (Liczba % i == 0 && Liczba != i)
                {
                    Console.WriteLine($"Liczba {Liczba} nie jest liczbą pierwszą, gdyż dzieli się np. przez {i}");
                    break;
                }
                else
                    Console.WriteLine($"Liczba {Liczba} jest liczbą pierwszą");
                reszta = Liczba % i;
                Console.WriteLine(reszta);
            }
#endif
            Console.ReadLine();
        }
    }
}
