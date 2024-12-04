namespace MSSQLApp.Data // Groups related classes.
{
    public class WeatherForecastService // Provides weather forecast data.
    {
        private static readonly string[] Summaries = new[] 
        // string[]: Declares that Summaries is an array of strings.
        //new[]: Initializes a new array without explicitly specifying its type.
        // Static list of weather descriptions.
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate) 
        // Asynchronously generates a 5-day forecast starting from `startDate`.
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast 
            // Generates 5 forecasts, one for each day.
            {
                Date = startDate.AddDays(index), // Sets the forecast date.
                TemperatureC = Random.Shared.Next(-20, 55), // Random temperature (Celsius).
                Summary = Summaries[Random.Shared.Next(Summaries.Length)] // Random summary from the list.
            }).ToArray()); // Converts the result to an array.
        }
    }
}
