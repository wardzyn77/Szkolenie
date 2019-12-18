using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07___Instrukcja_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int vWarunek;
            switch (vWarunek)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("1");
                    break;
                case 3:
                    Console.WriteLine("1");
                    break;
                case 4:         //nie mozna zdefiniowac pomiedzy
                case 5:         //mozna definiowac kilka i dopiero co dla nich ma byc wykonane
                    Console.WriteLine("1");
                    break;
                case 6:
                    Console.WriteLine("1");
                    break;
                default:
                    Console.WriteLine("Nie zdefiniowane");
                    break;
            }
            Console.ReadKey;
        }
    }
}
