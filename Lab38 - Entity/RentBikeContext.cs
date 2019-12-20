using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38___Entity
{
    class RentBikeContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public RentBikesContext() : base ("Wardzyn")
        {

        }
    }
}
