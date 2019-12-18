using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12___Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica;
            tablica = new int[] {12, 14, 23, 45};

            Console.WriteLine($"Dlugosc tbl: {tablica.Length}, element 3: {tablica[3]}");
            tablica[3] = 111;
            Console.WriteLine($"Dlugosc tbl: {tablica.Length}, element 3: {tablica[3]} Idz do pętli");
            foreach (var item in tablica)
            {
                Console.WriteLine($"Dlugosc tbl: {tablica.Length}, element : {item}");
            }
            int[] tablica2 = new int[10];       //zadeklarowaliśmy długosc tablicy na 10
            tablica2[1] = 2;
            tablica2[5] = 33;            
            foreach (var item in tablica2)
            {
                Console.WriteLine(item);        //tam gdzie nie ma wartosci poda nam 0 - to int
            }

            Console.ReadKey();
        }
    }
}
