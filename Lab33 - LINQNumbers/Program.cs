#define active 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33___LINQNumbers
{
    // może zastąpić Select po bazie, pliku, etc.
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 55, 77, 123, 99, 4, 12, 43, 33, 77 };
#if (aactive)
            //podana listę(numbers) pobieramy (numbers.Take(3), gdzie 3 mowi ile elementow), modyfikujemy (w IEnumerable) i odbieramy (modifyNumbers)
            IEnumerable<int> modifyNumbers = numbers.Take(3);

#elif (xactive)
            IEnumerable<int> modifyNumbers = numbers.Skip(3);
#elif (active)
            IEnumerable<int> modifyNumbers = numbers.Reverse();
#endif
            foreach (var item in modifyNumbers)
            {
                Console.Write(item +", ");
            }
            Console.ReadKey();
        }
    }
}
