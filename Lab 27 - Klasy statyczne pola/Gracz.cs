using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_27___Klasy_statyczne_pola
{
    class Gracz
    {
        public string Nick{get; set;}
        public int Id { get; }  // nie mając set mozna zmienic tylko poprzez konstruktor!!!
        public static int NastepnyId { get; set; }

        public Gracz()
        {
            Console.WriteLine("Domyślny konstruktor Gracza");
            Nick = null;
            Id = -10;
        }

        public Gracz(string nick)
        {
            Nick = nick;
            NastepnyId++;
            Id = NastepnyId;
        }


    }
}
