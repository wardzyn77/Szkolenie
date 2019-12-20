using Projekt.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.DB
{
    interface IWriter
    {
        void Write(Item item);
        void Remove(int id);
    }
}
