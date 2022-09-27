using Microsoft.AspNetCore.Mvc;
using ReactProject.Entities;

namespace ReactProject.Controllers
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        
        [HttpPost]
        [Route("")]
        public string Login()
        {
            return "OK!!";
        }

        //[HttpPost("weatherforecast/Login")]
        [HttpPost]
        public string Login([FromBody] User usuario)
        {
            if (usuario.FirstName == "Andrey")
            {
                //return new JsonResult("Ok");
                //return Ok();
                return "OK";
            }
            //return NotFound(); //new JsonResult("NotFound");
            return "ERRO";
        }
    }
}