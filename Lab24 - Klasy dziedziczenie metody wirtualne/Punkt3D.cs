using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24___Klasy_dziedziczenie_metody_wirtualne
{
    class Punkt3D : Punkt2D 
    {
        public int z;

        public Punkt3D(int x, int y, int z) : base (x,y)
        {
            this.z = z;
        }
        override public string PokazWspolrzedne()
        //override zadziała tylko przy zastosowaniu virtual przy metodzie rodzica
        {
            return this.x + " " + this.y + $" {this.z}";
        }
    }
}
