using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab41___wielowatkowosc
{
    class Robotnik
    {
        public void wypisz1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Robotnik1");
                Console.ResetColor();
            }
        }
        public void wypisz2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Robotnik222");
                Console.ResetColor();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Robotnik robotnik1 = new Robotnik();
            Robotnik robotnik2 = new Robotnik();
            Thread t1 = new Thread(robotnik1.wypisz1);
            Thread t2 = new Thread(robotnik2.wypisz2);
            t1.Start();
            t2.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("++++++++++++++++");
                Console.ResetColor();
            }
            //przy obsludze watkow komendy leca w roznej kolejnosci, przez co wyswietlanie nastepuje losowo!!! 
            Console.ReadKey();
        }
    }
}
