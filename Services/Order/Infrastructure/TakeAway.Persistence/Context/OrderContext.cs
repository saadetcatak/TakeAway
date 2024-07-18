using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Domain.Entities;

namespace TakeAway.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAADET\\SQLEXPRESS01; initial catalog=TakeAwayOrderDb; integrated security=true");
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Ordering> Ordering { get; set; }
    }
}
