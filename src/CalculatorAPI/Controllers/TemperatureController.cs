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
        public ActionResult<ServiceResponse<TemperatureResponseDto>> FahrenheitToCelsius(double fahrenheit)
        {
            ServiceResponse<TemperatureResponseDto> response = this.temperatureService.FahrenheitToCelsius(fahrenheit);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("CelsiusToFahrenheit")]
        public ActionResult<ServiceResponse<TemperatureResponseDto>> CelsiusToFahrenheit(double celsius)
        {
            ServiceResponse<TemperatureResponseDto> response = this.temperatureService.CelsiusToFahrenheit(celsius);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }
    }
}
