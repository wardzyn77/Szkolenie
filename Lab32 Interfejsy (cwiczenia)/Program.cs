using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Interfejsy__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto1 a = new Konto1();
            Konto2 b = new Konto2();

            a.Wplac(300);
            b.Wplac(500);
            Console.WriteLine($"Saldo a: {a.Saldo} Saldo b: {b.Saldo}");
            Console.WriteLine("----------------PO Przelewie--------------");
            b.ZrobPrzelew(a, 150);
            Console.WriteLine($"Saldo a: {a.Saldo} Saldo b: {b.Saldo}");


            Console.ReadKey();
        }
    }
}
