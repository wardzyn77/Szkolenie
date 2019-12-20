using Lab43___DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab43___DLL_import
{
    class Program
    {
        //dodanie do uzytkowania dll - references (prawy myszy)
        static void Main(string[] args)
        {
            KlasMath km = new KlasMath();
            Console.WriteLine(km.Dodaj(2,4));
            Console.ReadKey();
        }
    }
}
