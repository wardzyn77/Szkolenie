#define a
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33___LINQ_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kasia", "Ani/%a", "Piotr", "piotr", "arek", "zofia", "Zofiaa", "Zofia", "Kazik" };
#if (aa)
            //IEnumerable<string> modifNames = System.Linq.Enumerable.Where(names, n => n.Length > 7);  //nie używamy
            //POWYZEJ: bierzemy listę 'names', przypisujemy ją do 'n' i pobieramy tylko takie, które mają Lenth>7
            IEnumerable<string> modifNames = names.Where(n => n.Length > 7);   // tak uzywamy

#elif (aaa)
            //IEnumerable<string> modifNames = from n in names where n.Contains("p") select n;   //nie używamy
            IEnumerable<string> modifNames = names.Where(n => n.Contains("f"));
#elif (az)
            IEnumerable<string> modifNames = names.OrderBy(n => n);
#elif (ax)
            IEnumerable<int> modifNames = names.Select(n => n.Length);
#elif (a)
            //IEnumerable<string> modifNames = names.Where(n => n.Contains("/f/"));
            //IEnumerable<string> filteredNames = names.Where(n => n.Contains("a") && n.Contains("s"));
            IEnumerable<string> filteredNames = names.Where(n => n.Contains("ia"));
            IEnumerable<string> orderedNames = filteredNames.OrderBy(n => n);
            IEnumerable<string> modifNames = orderedNames.Select(n => n.ToUpper());
#elif (aw)
            IEnumerable<string> modifNames = names
                .Where(n => n.Contains("s"))
                .OrderBy(n => n)
                .Select(n => n.ToUpper());
            //przełamanie wiersza po prostu po enter, jedynym wyznacznikiem jest zakończenie ;


#endif
            foreach (var name in modifNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
