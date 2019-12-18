using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08___Typ_Enum
{
    class Program
    {
        //Typ wyliczeniowy
        //Definiujemy go poza głównym
        enum Stan
        {
            On,
            Off,
            Unknow
        } 
        static void Main(string[] args)
        {
            Stan Stan1 = Stan.Off;
            Console.WriteLine($"Stan: {Stan1}, wartość: {Convert.ToInt32(Stan1)}");

            Console.ReadKey();
        }
    }
}
