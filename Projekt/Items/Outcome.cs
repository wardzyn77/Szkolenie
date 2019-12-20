using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Items
{
    class Outcome : Item
    {
        //ctr+R ctr+r (podwojne) zmienia nazwy danego pola, etc w calej solucji
        public Outcome(int id, string name, decimal amount, DateTime date)
        {
            Id = id;
            Name = name;
            Type = ItemType.Outcome;
            Amount = amount;
            Date = date;
        }
    
    }
}
