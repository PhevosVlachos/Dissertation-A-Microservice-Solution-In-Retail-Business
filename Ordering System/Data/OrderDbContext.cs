using Microsoft.EntityFrameworkCore;
using Ordering_System.Model;
using System.Collections.Generic;

namespace Ordering_System.Data
{
    public class OrderDbContext : DbContext
    {


        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        { }
    }
}
