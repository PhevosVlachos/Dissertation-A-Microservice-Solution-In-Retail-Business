using Cart_System.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cart_System.Data
{
    public class CartDbContext : DbContext
    {

        public DbSet<Cart> Cart { get; set; }


        public DbSet<CartDetails> CartDetails { get; set; }

        public DbSet<Account> Customers { get; set; }

        public DbSet<Product> Products { get; set; }


        public CartDbContext(DbContextOptions<CartDbContext> options) : base(options)
        { }

    }
}
