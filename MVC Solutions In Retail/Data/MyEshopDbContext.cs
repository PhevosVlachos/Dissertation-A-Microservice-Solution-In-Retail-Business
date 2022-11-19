using Microsoft.EntityFrameworkCore;
using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Data
{


    public class MyEshopDbContext :  DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public MyEshopDbContext(DbContextOptions<MyEshopDbContext> options) : base(options)
        { }
    }}
