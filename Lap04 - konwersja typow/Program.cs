using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04___konwersja_typow
{
    class Program
    {
        static void Main(string[] args)
        {
            //rzutowanie niejawne NIE ROBIĆ!!!!!
            byte vByte1 = 255;
            int vIntNr = vByte1;
            Console.WriteLine(vIntNr);

            //przy rzutowaniu niejawnym, jak poniżej, i wprowadzeniu wiekszej wartosci niz zmienna przyjmuje - tu bajt - nastapi przekrecenie licznika i NIE wywali bledu
            // rzutowanie jawne NIE ROBIĆ!!!!!!
            vIntNr = 255;
            vByte1 = (byte)vIntNr;
            Console.WriteLine(vIntNr);

            //Convert
            byte vByte4;
            int vIntNr1 = 400;      //przeciążenie, byte jest do 255
            vByte4 = Convert.ToByte(vIntNr1);
            Console.WriteLine(vIntNr);

            //Parse
            string vStrNr8 = "200";
            byte vByte8 = byte.Parse(vStrNr8);
            Console.WriteLine(vStrNr8);

            Console.ReadKey(); 
        }
    }
}
