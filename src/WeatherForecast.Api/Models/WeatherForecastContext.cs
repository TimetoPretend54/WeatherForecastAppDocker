namespace WeatherForecast.Api.Models
{
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class WeatherForecastContext : DbContext
    {
        public WeatherForecastContext(DbContextOptions options) : base(options)
        {
        }

        // Must match table name that you want to query in Database (so in this case "dbo.DailyWeather"
        public DbSet<WeatherEntity> DailyWeather { get; set; }
    }
}
