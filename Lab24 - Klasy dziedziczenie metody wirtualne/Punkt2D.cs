using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24___Klasy_dziedziczenie_metody_wirtualne
{
    class Punkt2D
    {
        public int x;
        public int y;

        public Punkt2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        virtual public string PokazWspolrzedne()
        {
            return $"{x} {y}";
        }
    }
}
