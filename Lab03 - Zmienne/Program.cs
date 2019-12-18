using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03___Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liczby calkowite
            byte vByte = 255;
            Console.WriteLine($"zmienna vByte - [ {vByte} ]");
            Console.WriteLine($"zmienna vByte - min: [ {Byte.MinValue} ] do max: [ {Byte.MaxValue} ]");
            
            sbyte vSbyte = 100;
            Console.WriteLine($"zmienna vSbyte - [ {vSbyte} ]");
            Console.WriteLine($"zmienna vSbyte - min: [ {SByte.MinValue} ] do max: [ {SByte.MaxValue} ]");

            short vShort = 100;
            Console.WriteLine($"zmienna vShort - [ {vShort} ]");
            Console.WriteLine($"zmienna vShort - min: [ {Int16.MinValue} ] do max: [ {Int16.MaxValue} ]");

            ushort vUShort = 100;
            Console.WriteLine($"zmienna vUShort - [ {vUShort} ]");
            Console.WriteLine($"zmienna vUShort - min: [ {UInt16.MinValue} ] do max: [ {UInt16.MaxValue} ]");

            int vInt = 100;
            Console.WriteLine($"zmienna vInt - [ {vInt} ]");
            Console.WriteLine($"zmienna vInt - min: [ {Int32.MinValue} ] do max: [ {Int32.MaxValue} ]");

            uint vUInt = 100;
            Console.WriteLine($"zmienna vUInt - [ {vUInt} ]");
            Console.WriteLine($"zmienna vUInt - min: [ {UInt32.MinValue} ] do max: [ {UInt32.MaxValue} ]");

            long vLong = 100;
            Console.WriteLine($"zmienna vLong - [ {vLong} ]");
            Console.WriteLine($"zmienna vLong - min: [ {Int64.MinValue} ] do max: [ {Int64.MaxValue} ]");

            ulong vULong = 100;
            Console.WriteLine($"zmienna vULong - [ {vULong} ]");
            Console.WriteLine($"zmienna vULong - min: [ {UInt64.MinValue} ] do max: [ {UInt64.MaxValue} ]");

            //Liczby zmiennoprzecinkowe

            float vFloat = 1.5f;
            Console.WriteLine($"zmienna vFloat - [ {vFloat} ]");
            Console.WriteLine($"zmienna vFloat - min: [ {Single.MinValue} ] do max: [ {Single.MaxValue} ]");

            double vDouble = 1.5;
            Console.WriteLine($"zmienna vDouble - [ {vDouble} ]");
            Console.WriteLine($"zmienna vDouble - min: [ {Double.MinValue} ] do max: [ {Double.MaxValue} ]");

            decimal vDecimal = 1.5M;
            Console.WriteLine($"zmienna vDecimal - [ {vDecimal} ]");
            Console.WriteLine($"zmienna vDecimal - min: [ {Decimal.MinValue} ] do max: [ {Decimal.MaxValue} ]");

            //Boolean
            bool vBool = true;
            Console.WriteLine($"zmienna vBool - [ {vBool} ]");
            vBool = false;
            Console.WriteLine($"zmienna vBool - [ {vBool} ]");

            //NullAble
            int? zmiennaNULL = null;
            Console.WriteLine($"zmienna zmiennaNULL - [ {zmiennaNULL} ]");

            //Typ znakowy
            char vChar = 's';
            Console.WriteLine($"zmienna vChar - [ {vChar} ]");

            //lancuch znakow
            string vImie = "Jan";
            string vNazwisko = "  Kowalski   ";
            Console.WriteLine($"zmienna string {vImie} {vNazwisko}");
            Console.WriteLine($"zmienna string {vImie.ToUpper()} {vNazwisko.ToLower()}");
            Console.WriteLine($"zmienna string {vImie.Trim()} {vNazwisko.Trim()}");
            Console.WriteLine($"zmienna string {vImie} {vNazwisko.Substring(2,4)}");

            // jesli w tekscie chcemy zastosowac \ to kompliator oczekuje przy nastepnym znaku wykonania specjalnego, np \n - NewLine. Dla wprowadzenia znaku \ nalezy wprowadzic \\ lub $@ przed calym tekstem
            Console.WriteLine("d:\\moje_pliki\\plik.txt");
            Console.WriteLine($@"d:\moje_pliki\plik.txt");

            //VAR - zmienna var od razu MUSI miec przypisana wartosc, inaczej niz pozostale!!! Podczas tej czynnosci OKRESLANY jest automatycznie typ w zaleznosci od przypisanej wartosc
            var vZmienna = "abc";
            Console.WriteLine(vZmienna);
            Console.WriteLine(vZmienna.GetType());

            var vZmiennInt = 22;
            Console.WriteLine(vZmiennInt);
            Console.WriteLine(vZmiennInt.GetType());

            //Dynamic - MOCNO spowalnia dzialanie aplikacji, wiec NIE korzystamy, chyba ze mus
            Console.WriteLine("Typ DYNAMIC");
            dynamic vDynamic;            
            // Console.WriteLine(vDynamic.GetType()); - NIE wie jaki typ, wiec blad
            vDynamic = 12;
            Console.WriteLine(vDynamic);
            Console.WriteLine(vDynamic.GetType());
            vDynamic = "ss";
            Console.WriteLine(vDynamic);
            Console.WriteLine(vDynamic.GetType());

            //Object
            Console.WriteLine("Typ Object");
            object vObject = 0;
            Console.WriteLine(vObject);
            Console.WriteLine(vObject.GetType());
            vObject = "sss";
            Console.WriteLine(vObject);
            Console.WriteLine(vObject.GetType());

            //DATA
            Console.WriteLine($"Teraz data: [ {DateTime.Now} ]");
            Console.WriteLine($"Dzis data: [ {DateTime.Today} ]");
            Console.WriteLine($"Wczoraj data: [ {DateTime.Today.AddDays(-1)} ]");
            Console.WriteLine($"Wczoraj data: [ {DateTime.Today.DayOfYear} ]");
            Console.WriteLine($"Wczoraj data: [ {DateTime.UtcNow} ]");

            DateTime vdtData = DateTime.Now;
            Console.WriteLine($"Teraz data moja: [ {vdtData} ]");

            DateTime vdtDataUTC = DateTime.UtcNow;
            Console.WriteLine($"Teraz data mojaUTC: [ {vdtDataUTC} ]");
            Console.WriteLine($"Teraz data moja: [ {vdtDataUTC.ToLocalTime()} ]");    //zamiana na lokalna, wzgledem ustwaien lokalnych
            DateTime vdtData2 = new DateTime(2017, 04, 13);
            Console.WriteLine($"Data: [ {vdtData2} ]");


            Console.ReadKey();
        }
    }
}
