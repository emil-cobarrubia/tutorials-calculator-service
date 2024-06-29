using Calculator.DTOs;
using Calculator.Constants;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weight.Services;
using CalculatorAPI;
namespace Calculator.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeightController : ControllerBase
{
    private IWeightService weightService;
    public WeightController()
    {
        this.weightService = new WeightService();
    }

    /// <summary>
    /// Gets your equivalent weight on another planet provided your given weight on Earth.
    /// Units aren't necessary when translating weight on other planets as it'll be a 
    /// multiplication factor of the input.  That is, if you enter a value that's 
    /// represenative of pounds, the result, represents the value in said unit, which is pounds.
    /// </summary>
    /// <param name="weight">Weight on Earth</param>
    /// <param name="planet">Planet</param>
    /// <returns>Equivalent weight on planet selected.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     weight: 180
    ///     planet: Jupiter
    ///     
    /// Valid Planets:
    /// 
    ///     Sun
    ///     Mercury
    ///     Venus
    ///     Earth
    ///     EarthMoon
    ///     Mars
    ///     Jupiter
    ///     Saturn
    ///     Uranus
    ///     Neptune
    ///     Pluto
    ///     
    /// </remarks>
    /// <response code="200">Returns the equivalent weight on a planet given a valid weight on Earth.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("GetWeightOnPlanet")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnPlanet(double weight, string planet)
    {
        ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnPlanet(weight, planet);

        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }
}
