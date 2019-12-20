using Lab38___Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38___Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikes = new List<Bike>
            {
                new Bike{Number = "001", BikeType = BikeType.Mountain},
                new Bike{Number = "002", BikeType = BikeType.Road},
                new Bike{Number = "003", BikeType = BikeType.Mountain},
                new Bike{Number = "004", BikeType = BikeType.Town},
                new Bike{Number = "005", BikeType = BikeType.Mountain}
            };

            using (var context = new RentBikeContext())
            {
                context.Bikes.AddRange(bikes);
                context.SaveChanges();
            }
        }
    }
}
