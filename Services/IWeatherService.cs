using WeatherBroadcastApi.Models;

namespace WeatherBroadcastApi.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetForecastByCity(string city, int days = 5);
    WeatherForecast GetCurrentWeather(string city);
}
