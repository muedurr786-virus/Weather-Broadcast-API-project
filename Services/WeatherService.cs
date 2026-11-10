using WeatherBroadcastApi.Models;

namespace WeatherBroadcastApi.Services;

public class WeatherService : IWeatherService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecast> GetForecastByCity(string city, int days = 5)
    {
        var rng = new Random(city.ToLower().GetHashCode());
        return Enumerable.Range(1, days).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            City = city,
            TemperatureC = rng.Next(-10, 40),
            Summary = Summaries[rng.Next(Summaries.Length)],
            Humidity = rng.Next(30, 95),
            WindSpeedKmh = Math.Round(rng.NextDouble() * 30 + 5, 1)
        });
    }

    public WeatherForecast GetCurrentWeather(string city)
    {
        var rng = new Random();
        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now),
            City = city,
            TemperatureC = rng.Next(-5, 38),
            Summary = Summaries[rng.Next(Summaries.Length)],
            Humidity = rng.Next(40, 90),
            WindSpeedKmh = Math.Round(rng.NextDouble() * 25 + 5, 1)
        };
    }
}
