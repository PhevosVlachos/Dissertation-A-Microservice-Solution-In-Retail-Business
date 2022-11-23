using Microsoft.EntityFrameworkCore;
using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Data
{


    public class MyDbContext :  DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
    }}
