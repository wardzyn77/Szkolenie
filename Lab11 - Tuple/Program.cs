using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11___Tuple
{
    class Program
    {
        static (string imie, string nazwisko) DajOsobe()        //zwraca więcej niż 1 parametr
        {
            var nazwa = (imie: "Jan", nazwisko: "Kowalski");
            return nazwa;
        }
        static void Main(string[] args)
        {
            var nazwaCos = DajOsobe();

            Console.WriteLine(nazwaCos);
            Console.WriteLine(nazwaCos.GetType());
            Console.WriteLine(nazwaCos.Item1);

            Console.ReadKey();
        }
    }
}
