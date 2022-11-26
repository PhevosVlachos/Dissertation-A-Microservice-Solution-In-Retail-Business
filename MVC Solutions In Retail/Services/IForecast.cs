using MVC_Solutions_In_Retail.Model;

namespace MVC_Solutions_In_Retail.Services
{
    public interface IForecast
    {
        public void MakeForecasts();

        public List<WeatherForecast> ReadForecasts();
    }
}
