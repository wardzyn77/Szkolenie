using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09___Typ_Enum_Switch
{
    class Program
    {
        enum  State
        {
On,
Off,
Unknow
        }
        static void Main(string[] args)
        {
            switch (State)
            {
                case State.On:
                    Console.WriteLine("Stan włączony");
                    break;
                case State.Off:
                    Console.WriteLine("Stan wyłączony");
                    break;
                case State.Unknow:
                    Console.WriteLine("Stan nieznany");
                    break;
                default:
                    Console.WriteLine("Stan POZA wartością");
                    break;
            }
        }
    }
}
