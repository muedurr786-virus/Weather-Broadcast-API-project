namespace WeatherBroadcastApi.Models;

public class WeatherForecast
{
    public DateOnly Date { get; set; }
    public string City { get; set; } = string.Empty;
    public int TemperatureC { get; set; }
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    public string? Summary { get; set; }
    public int Humidity { get; set; }
    public double WindSpeedKmh { get; set; }
}
