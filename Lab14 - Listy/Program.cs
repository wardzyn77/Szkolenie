using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14___Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();
            lista1.Add("Pawl");
            lista1.Add("Adam");
            lista1.Add("Paweł");
            lista1.Add("Piotr");
            lista1.Add("pio");
            lista1.Add("maciek");
            lista1.Add("mirek");
            lista1.Add("marcin");
            Console.WriteLine($"Ilosc elementow: {lista1.Count}, element 5: {lista1[4]}");
            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }
            lista1.RemoveAt(4);     //usuwa element listy. powoduje to zmiane indeksow elementow nastepnych 
            string zmienna = lista1[4];
            lista1.Remove(zmienna);



            Console.ReadKey();
        }
    }
}
