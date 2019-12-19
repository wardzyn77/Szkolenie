using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29___Klasy_generyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //klasa ArrayList czy List są klasami generycznymi
            ArrayList lista = new ArrayList();
            lista.Add("aa");
            lista.Add("cc");
            lista.Add(22);
            foreach (var item in lista)
            {
                Console.WriteLine($"{item} -> {item.GetType()}");
            }
            var zmiennaString = new Generyczna<string>();
            zmiennaString.NadajWartosc("wardzyn");
            Console.WriteLine(zmiennaString.ZwrocWartosc());

            var zmiennaInt = new Generyczna<int>();
            zmiennaInt.NadajWartosc(112);
            Console.WriteLine(zmiennaInt.ZwrocWartosc());


            Console.ReadKey();
        }
    }
}
