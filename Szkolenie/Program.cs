using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 55, 77, 123, 99, 4, 12, 43, 33, 77 };
            int firstNumber = numbers.First();            
            Console.WriteLine(firstNumber);
            Console.WriteLine(numbers.ElementAt(5));    //5 - nr indexu w liscie
            int drugiMin = numbers.OrderBy(r => r).Skip(1).FirstOrDefault();        //r => r = wyrażenie lambda, nazwa dowolna
            Console.WriteLine($"drugi min: {drugiMin}");



            Console.ReadKey();
        }
    }
}
