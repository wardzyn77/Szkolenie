
using System;

namespace Lab30___metody_generyczne
{
    class Program
    {
        //...chyba jest jako NET.Core zamiast 
        public static void Zamien<T> (ref T a, ref T b)
        {
            T tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 33;
            Console.WriteLine($"a: {a},| b: {b}");
            Zamien(ref a,ref b);
            Console.WriteLine($"a: {a},| b: {b}");

            string c = "wardzyn";
            string d = "motylek";
            Console.WriteLine($"{c}|||||{d}");
            Zamien(ref c,ref d);
            Console.WriteLine($"{c}|||||{d}");

            Zamien<string>(ref c, ref d);   //jak tak urucomimy, to od razu wymagamy za c i d string

            //Console.WriteLine("Hello World!");


            Console.ReadKey();
        }
    }
}
