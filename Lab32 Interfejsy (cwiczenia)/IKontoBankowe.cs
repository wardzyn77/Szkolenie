using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Interfejsy__cwiczenia_
{
    interface IKontoBankowe
    {
        decimal Saldo { get; }

        void Wplac(decimal kwota);

        bool Wyplac(decimal kwota);

        bool ZrobPrzelew(IKontoBankowe konto, decimal kwota);
        
    }
}
