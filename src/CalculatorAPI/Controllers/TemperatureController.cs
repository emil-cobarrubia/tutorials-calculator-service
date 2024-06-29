using Calculator.DTOs;
using Calculator.Services;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemperatureController : ControllerBase
{
    private ITemperatureService temperatureService;
    public TemperatureController()
    {
        this.temperatureService = new TemperatureService();
    }

    /// <summary>
    /// Converts Fahrenheit degrees to Celsius degrees.
    /// </summary>
    /// <param name="fahrenheit">Degrees in Fahrenheit</param>
    /// <returns>Returns the degrees in Celsius.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     fahrenheit: 99.4
    ///     
    /// </remarks>
    /// <response code="200">Returns the Celsius degree if given a valid Fahrenheit number.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("FahrenheitToCelsius")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public ActionResult<ServiceResponse<TemperatureResponseDto>> FahrenheitToCelsius(double fahrenheit)
    {
        ServiceResponse<TemperatureResponseDto> response = this.temperatureService.FahrenheitToCelsius(fahrenheit);
        
        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Converts Celsius degrees to Fahrenheit degrees.
    /// </summary>
    /// <param name="celsius">Degrees in Celsius</param>
    /// <returns>Returns the degrees in Fahrenheit.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     fahrenheit: 33
    ///     
    /// </remarks>
    /// <response code="200">Returns the Fahrenheit degree if given a valid Celsius number.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("CelsiusToFahrenheit")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public ActionResult<ServiceResponse<TemperatureResponseDto>> CelsiusToFahrenheit(double celsius)
    {
        ServiceResponse<TemperatureResponseDto> response = this.temperatureService.CelsiusToFahrenheit(celsius);

        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }
}
