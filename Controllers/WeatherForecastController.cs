using Microsoft.AspNetCore.Mvc;
using WeatherBroadcastApi.Models;
using WeatherBroadcastApi.Services;

namespace WeatherBroadcastApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    /// <summary>
    /// Gets current live weather broadcast for a city.
    /// </summary>
    [HttpGet("current/{city}")]
    public ActionResult<WeatherForecast> GetCurrent(string city)
    {
        var weather = _weatherService.GetCurrentWeather(city);
        return Ok(weather);
    }

    /// <summary>
    /// Gets multi-day weather forecast broadcast for a city.
    /// </summary>
    [HttpGet("forecast/{city}")]
    public ActionResult<IEnumerable<WeatherForecast>> GetForecast(string city, [FromQuery] int days = 5)
    {
        var forecast = _weatherService.GetForecastByCity(city, days);
        return Ok(forecast);
    }
}
