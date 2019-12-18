using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13___Tablica_Dwuwymiarowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[5, 6];
            Random random = new Random();
            //Console.WriteLine(random.Next(100));
            for (int rownumber = 0; rownumber < tablica.GetLength(0); rownumber++)
            //  tablica.GetLength(i) - pokazuje dlugosc danego wymiaru tablicy
            {
                for (int colnumber = 0; colnumber < tablica.GetLength(0); colnumber++)
                {
                    //Console.WriteLine();
                    tablica[rownumber, colnumber] = random.Next(100);
                }

            }
            for (int rownumber = 0; rownumber < tablica.GetLength(0); rownumber++)
            {
                for (int colnumber = 0; colnumber < tablica.GetLength(1); colnumber++)
                {
                    Console.Write($"{tablica[rownumber, colnumber]} ");
                    tablica[rownumber, colnumber] = random.Next(100);
                }
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
