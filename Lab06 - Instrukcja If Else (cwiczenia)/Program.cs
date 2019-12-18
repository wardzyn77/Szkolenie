#define Cw1 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06___Instrukcja_If_Else__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            double vWzrost = 1.8;
            int vWaga = 90;
            double vBMI;
            string vOpisBMI;
            vBMI = (System.Math.Pow(vWzrost, 2));
            vBMI = vWaga / vBMI;
            if (vBMI < 16)
            {vOpisBMI = "Wygłodzenie";
            }else if (vBMI <17 )
            { vOpisBMI = "wychudzenie";}
            else if (vBMI < 18.5 )
            { vOpisBMI = "niedowaga"; }
            else if (vBMI < 25)
            { vOpisBMI = "wartość prawidłowa"; }
            else if (vBMI < 30)
            { vOpisBMI = "nadwaga"; }
            else if (vBMI < 35)
            { vOpisBMI = "I stopień otyłości"; }
            else if (vBMI < 40)
            { vOpisBMI = "II stopień otyłości"; }
            else 
            vOpisBMI = "otyłość skrajna"; 
            Console.WriteLine($"Twój wynik BMI: {vBMI}");
            Console.WriteLine(vOpisBMI);//, jest to: {vOpisBMI}");

#if (Cw1)

#endif 
            Console.ReadKey();
        }
    }
}
