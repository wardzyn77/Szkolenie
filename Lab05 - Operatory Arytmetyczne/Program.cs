using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05___Operatory_Arytmetyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 + 5 = " + 2 + 5);
            Console.WriteLine("2 + 5 = " + (2 + 5));
            Console.WriteLine("5 / 2 = " + (5 / 2));        //są int, więc = 2
            Console.WriteLine("5 / 2 = " + (5 / 2.0));        // więc = 2.5
            int a = 5;
            Console.WriteLine(a);
            Console.WriteLine(a++); //posinkrementacja!!! najpierw wyswietla, potem podnosi
            Console.WriteLine(a++);
            Console.WriteLine(++a); //preinkrementacja!!! najpierw podnosi, potem  wyswietla
            //a + = 1;
            Console.WriteLine(a);

        }
    }
}
