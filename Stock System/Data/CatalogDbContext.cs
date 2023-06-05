using Microsoft.EntityFrameworkCore;
using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Data
{


    public class CatalogDbContext :  DbContext
    {
        

        public DbSet<Product> Products { get; set; }

       

        

       public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        { }
    }
}
