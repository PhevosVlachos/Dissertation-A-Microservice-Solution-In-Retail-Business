using Microsoft.EntityFrameworkCore;
using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Data
{


    public class MyDbContext :  DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<MyCatalogue> MyCatalogue { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
    }}
