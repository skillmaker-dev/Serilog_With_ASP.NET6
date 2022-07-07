using Microsoft.AspNetCore.Mvc;

namespace PracticalSerilog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //Logging any info using the injected _logger
            _logger.LogInformation("GetWeatherForecast Called");

            try
            {
                for(int i = 0; i < 50; i++)
                {
                    _logger.LogInformation("Value of i is {valueofi}", i);
                    if (i == 40)
                        throw new Exception("This is an exception");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "This exception was thrown");
            }

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}