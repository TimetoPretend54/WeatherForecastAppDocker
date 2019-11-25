namespace WeatherForecast.Api.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class WeatherEntity
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}
