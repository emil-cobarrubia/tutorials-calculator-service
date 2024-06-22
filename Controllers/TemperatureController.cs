using Calculator.DTOs;
using Calculator.Services;
using Calculator.Interfaces;
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
        public ActionResult<TemperatureResponseDto> FahrenheitToCelsius(double fahrenheit)
        {
            TemperatureResponseDto response = this.temperatureService.FahrenheitToCelsius(fahrenheit);
            return Ok(response);
        }

        [HttpGet]
        [Route("CelsiusToFahrenheit")]
        public ActionResult<TemperatureResponseDto> CelsiusToFahrenheit(double celsius)
        {
            TemperatureResponseDto response = this.temperatureService.CelsiusToFahrenheit(celsius);
            return Ok(response);
        }
    }
}
