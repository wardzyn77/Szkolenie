
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34___Zapis_Do_Pliku
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"d:\test.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("plik istnieje");
            }
            else Console.WriteLine("pliku brak");

            string tekst = "to jest tekst z programu";

            File.WriteAllText(path, tekst);
            File.AppendAllText(path, tekst);

            tekst = tekst + Environment.NewLine;

            List<string> lines = new List<string>()
            {
                "linia pierwsza",
                "linia druga",
                "linia trzecia",
            };

            File.WriteAllLines(path, lines);
            File.AppendAllLines(path, lines);

            Console.ReadKey();
        }
    }
}