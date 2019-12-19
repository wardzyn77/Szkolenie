using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Interfejsy__cwiczenia_
{
    class Konto2 : IKontoBankowe

    {
        public decimal Saldo { get; private set; }

        public void Wplac(decimal kwota)
        {
            Saldo += kwota;
        }

        public bool Wyplac(decimal kwota)
        {
            if (Saldo >= kwota)
            {
                Saldo -= kwota;
                return true;
            }
            Console.WriteLine("Za mało środków na koncie");
            return false;
        }

        public bool ZrobPrzelew(IKontoBankowe kontoCel, decimal kwota)
        {
            bool wyplacono = this.Wyplac(kwota);
            if (wyplacono)
            {
                kontoCel.Wplac(kwota);
                //return true;
            }
            return wyplacono;
        }
    }
}
