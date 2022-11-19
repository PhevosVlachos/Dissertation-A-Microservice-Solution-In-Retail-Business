using Microsoft.EntityFrameworkCore;
using MVC_Solutions_In_Retail.Data;
using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Services
{
    public class Forecast : IForecast
    {

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private MyEshopDbContext _context;
        public Forecast(MyEshopDbContext context)
        {
            _context = context;
        }

        public void MakeForecasts()
        {
            List<WeatherForecast> forecasts =  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();

            forecasts.ForEach(f => _context.WeatherForecasts.Add(f));
            _context.SaveChanges();
            
        }

        public List<WeatherForecast> ReadForecasts()
        {
            return _context.WeatherForecasts.ToList();
        }
    }
}
