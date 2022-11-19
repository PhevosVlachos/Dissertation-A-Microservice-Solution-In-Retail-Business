using Microsoft.AspNetCore.Mvc;
using MVC_Solutions_In_Retail.Model;
using MVC_Solutions_In_Retail.Services;

namespace MVC_Solutions_In_Retail.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
      

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IForecast _forecast;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IForecast forecast)
        {
            _logger = logger;
            _forecast = forecast;
        }

        [HttpGet("GetWeatherForecast")]
        //[Route("GetWeatherForecast")]
        public List<WeatherForecast> Get()
        {
            return _forecast.ReadForecasts();
        }

        [HttpGet("CreateWeatherForecast")]
        //[Route("CreateWeatherForecast")]
        public string Create()
        {
            _forecast.MakeForecasts();
            return "Ok";
        }
    }
}