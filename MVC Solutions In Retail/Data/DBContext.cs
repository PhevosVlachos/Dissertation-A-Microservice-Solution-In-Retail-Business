using Microsoft.EntityFrameworkCore;
using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Data
{


    public class DBContext :  DbContext
    {
        

        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

       public DbSet<MyCatalogue> MyCatalogue { get; set; }

        

       public DBContext(DbContextOptions<DBContext> options) : base(options)
        { }
    }
}
