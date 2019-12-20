using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Items
{
    abstract class Item
    {
        //klasa tylko do dziedziczenia. 
        //dlatego musi byc protected - dzieci mogą dziedziczyć
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public ItemType Type { get; protected set; }
        public decimal Amount { get; protected set; }
        public DateTime Date { get; protected set; }
    }
}
