using Projekt.DB;
using Projekt.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Statistics
{
    class List
    {
        private IReader reader;
        public List(IReader reader)
        {
            this.reader = reader;
        }
        private void DisplayLine(Item item)
        {
            string type = "";
            switch (item.Type)
            {
                case ItemType.Income:
                    type = "DOCHÓD";
                    break;
                case ItemType.Outcome:
                    type = "KOSZT";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{item.Id} {item.Name} {item.Type} {item.Amount} {item.Date}");
        }
        public void DisplayList()
        {
            IEnumerable<Item> list = reader.ReadAll();
            foreach (Item  item in list)
            {
                DisplayLine(item);
            }
        }
    }
}
