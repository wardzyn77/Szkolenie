using Projekt.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.DB
{
    class File : IWriter, IReader
    {
        private IList<Item> list;       //cos od IEnumerable, ale ograniczona - wbudowane
        public File()
        {
            list = new List<Item>();
        }
        public int GetNextId()
        {
            if (list.Count == 0)
            {
                return  1;
            }
            int lastIndex = list.Count - 1; //indexy od zera
            return list[lastIndex].Id + 1;
        }

        public IEnumerable<Item> ReadAll()
        {
            return list;
        }

        public void Remove(int id)
        {
            Item toRemove = null;
            foreach (Item  item in list)
            {
                if (id == item.Id)
                {
                    toRemove = item;
                    break;
                }
            }
            list.Remove(toRemove);
        }

        public void Write(Item item)
        {
            list.Add(item);
        }
    }
}
