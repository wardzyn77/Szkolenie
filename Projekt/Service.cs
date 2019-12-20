using Projekt.DB;
using Projekt.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Service
    {
        private IReader reader;
        private IWriter writer;

        public Service(IReader reader,IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void AddIncome(string name, decimal amount, DateTime date)
        {
            int id = reader.GetNextId();
            Income income = new Income(id, name, amount, date);
            writer.Write(income);
        }
        public void AddOutcome(string name, decimal amount, DateTime date)
        {
            int id = reader.GetNextId();
            Outcome outcome = new Outcome(id, name, amount, date);
            writer.Write(outcome);
        }
        public void RemoveById(int id)
        {
            writer.Remove(id);
        }
    }
}
