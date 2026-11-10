# ASP.NET Core Weather Broadcast API (.NET 8)

This project provides a clean RESTful Web API for broadcasting live weather forecasts and current weather metrics.

## Project Structure
- `Controllers/WeatherForecastController.cs`: Exposes API endpoints for current weather & forecast.
- `Models/WeatherForecast.cs`: Data model including Celsius/Fahrenheit calculations, humidity, wind speed.
- `Services/`: Business logic layer with Dependency Injection.

## How to Run
1. Ensure you have the [.NET 8 SDK](https://dotnet.microsoft.com/download) installed.
2. Open terminal in the project directory:
   ```bash
   dotnet restore
   dotnet run
   ```
3. Open browser and navigate to `https://localhost:7000/swagger` to explore and test endpoints via Swagger UI.

## Endpoints
- `GET /api/weatherforecast/current/{city}` - Get current weather broadcast.
- `GET /api/weatherforecast/forecast/{city}?days=5` - Get multi-day weather broadcast.
