using Calculator.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private ITemperatureService temperatureService;
        public TemperatureController()
        {
            this.temperatureService = new TemperatureService();
        }

        [HttpGet]
        [Route("FahrenheitToCelsius")]
        public Object FahrenheitToCelsius(double? fahrenheit)
        {
            var response = this.temperatureService.FahrenheitToCelsius(fahrenheit);
            return Ok(response);
        }

        [HttpGet]
        [Route("CelsiusToFahrenheit")]
        public Object CelsiusToFahrenheit(double? celsius)
        {
            var response = this.temperatureService.CelsiusToFahrenheit(celsius);
            return Ok(response);
        }
    }
}
