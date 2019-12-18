using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06___instrukcja_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int vNr = 40;
            int vNrB = 10;
            if (vNr > vNrB )
            {
                Console.WriteLine($"1: vNr większe vNrB ");
            } else if (vNr == vNrB)
            {
                Console.WriteLine($"2: vNr równe vNrB ");
            } else 
            {
                Console.WriteLine($"2: vNr mniejsze vNrB ");
            }

            Console.ReadKey();
        }
    }
}
