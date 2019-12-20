using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab37___Lazy
{
    class Samochod
    {
        public string marka;
        public int rokProdukcji;
        public Samochod(string marka, int rokProdukcji)
        {
            this.marka = marka;
            this.rokProdukcji = rokProdukcji;
            Console.WriteLine("konstruktor");
        }
    }
}