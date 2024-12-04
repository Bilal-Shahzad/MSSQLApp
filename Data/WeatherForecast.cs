namespace MSSQLApp.Data // Groups related classes.
{
    public class WeatherForecast // Represents weather data.
    {
        public DateOnly Date { get; set; } 
        // Forecast date (no time).

        public int TemperatureC { get; set; } 
        // Temperature in Celsius.

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556); 
        // Computed Fahrenheit temperature.

        public string? Summary { get; set; } 
        // Weather description (nullable).
    }
}


// get: Retrieves the value of a property.
// set: Assigns a value to a property.

