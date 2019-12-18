using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13___Tablica_Dwuwymiarowa__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[10, 10];
            Random los = new Random(100);            
            for (int wiersz = 0; wiersz < tablica.GetLength(0); wiersz++)
            {
                for (int kol = 0; kol < tablica.GetLength(1); kol++)
                {
                    tablica[wiersz,kol] = los.Next(0, 1000);
                }
            }
            int wierszN, kolN, wartosc;
            wartosc = 0;
            wierszN = 0;
            kolN = 0;
            for (int wiersz = 0; wiersz < tablica.GetLength(0); wiersz++)
            {
                for (int kol = 0; kol < tablica.GetLength(1); kol++)
                {
                    Console.Write($"{tablica[wiersz, kol]} ");
                    if (tablica[wiersz, kol]> wartosc)
                    {
                        wartosc = tablica[wiersz, kol];
                        wierszN = wiersz + 1;
                        kolN = kol + 1;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine($"Najwieksza wartosc tablicy: {wartosc}, wiersz: {wierszN}, kolumna: {kolN}");


            Console.ReadKey();
        }
    }
}
