#define p3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15___TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
#if (p1)
			try
			{
				Console.WriteLine("Podaj liczbe");
				int number =Convert.ToInt32 (Console.ReadLine());
				Console.WriteLine($"Pole kwa: {number} * {number}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"bledna liczba. {ex.Message}");	//ex.ToString - opis ze szczegółami 			
			}
			finally		//mimo błędu zrób poniżej
			{
				Console.WriteLine("zamkniemy :(");
			}

#elif (p2)
			try
			{
				int liczba1 = 4;
				int liczba2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(liczba1 / liczba2);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Podales 0, nie mozna dzielic przez 0");
			}
			catch (Exception)
			{

				throw;
			}
#elif (p3)
			try
			{
				int liczba1 = 4;
				int liczba2 = Convert.ToInt32(Console.ReadLine());
				//Console.WriteLine(liczba1 / liczba2);
				if (liczba2<=0)
				{
					throw new ArgumentException("wartość musi być liczbą dodatnią");
				}
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Podales 0, nie mozna dzielic przez 0");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);				
			}
#endif
			Console.ReadKey();
        }
    }
}
