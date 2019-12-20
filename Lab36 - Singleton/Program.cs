using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36___Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass s1 = SingletonClass.Instance;
            SingletonClass s2 = SingletonClass.Instance;
            Console.WriteLine(s1.Equals (s1));
            Console.ReadKey();
        }
    }
}
