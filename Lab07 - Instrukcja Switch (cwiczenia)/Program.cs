using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07___Instrukcja_Switch__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            string vDzien;
            Console.WriteLine(DateTime.Now.DayOfWeek);

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
