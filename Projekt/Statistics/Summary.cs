using Projekt.DB;
using Projekt.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Statistics
{
    class Summary
    {
        private IReader file;
        public Summary (IReader file)
        {
            this.file = file;
        }
        private IEnumerable<Item> GetItems (int year, int month)
        {
            IEnumerable<Item> list = file.ReadAll();
            List<Item> reportList = new List<Item>();
            foreach (Item  item in list)
            {
                if (item.Date.Year==year && item.Date.Month==month)
                {
                    reportList.Add(item);
                }
            }
            return reportList;
        }
        private decimal SumIncomes(IEnumerable<Item> list)
        {
            decimal sum = 0.0M;
            foreach (Item  item in list)
            {
                if (item.Type ==ItemType.Income)
                {
                    sum += item.Amount;
                }
            }
            return sum;
        }
        private decimal SumOutcomes(IEnumerable<Item> list)
        {
            decimal sum = 0.0M;
            foreach (Item item in list)
            {
                if (item.Type == ItemType.Outcome)
                {
                    sum += item.Amount;
                }
            }
            return sum;
        }

        private decimal Balance(decimal incomes, decimal outcomes)
        {
            return incomes - outcomes;
        }

public void DisplayReport (int year, int month)
        {
            IEnumerable<Item> list = GetItems(year, month);

            decimal incomes = SumIncomes(list);
            decimal outcomes = SumOutcomes(list);

            decimal balance = Balance(incomes, outcomes);

            Console.WriteLine($"Podsumowanie {month}/{year}");

            Console.WriteLine($"Suma dochodów: {incomes} PLN");
            Console.WriteLine($"Suma wydatków: {outcomes} PLN");

            Console.WriteLine("==============================");

            Console.WriteLine($"Bilans: {balance} PLN");
        }
    }
}
