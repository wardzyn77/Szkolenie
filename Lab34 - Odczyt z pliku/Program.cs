using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34___Odczyt_z_pliku
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            string path = $@"d:\test.txt";
            if (File.Exists(path))
            {
                //tekst = File.ReadAllText(path);
                List<string> lines = new List<string>(File.ReadAllLines(path));
                foreach (var item in lines)
                {
                    Console.WriteLine(item);
                }
            }
            else Console.WriteLine("Brak pliku");
            



            Console.ReadKey();
        }
    }
}
