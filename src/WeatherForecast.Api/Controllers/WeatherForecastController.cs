using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeatherForecast.Api.Controllers
{
    using Models;

    [Route("api/weatherForecast")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly WeatherForecastContext weatherForecastContext;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(WeatherForecastContext weatherForecastContext,
                                         ILogger<WeatherForecastController> logger)
        {
            this.weatherForecastContext = weatherForecastContext;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var query = weatherForecastContext.DailyWeather.ToList();

            return Ok(query);
        }
    }
}
