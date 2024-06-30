using Calculator.DTOs;
using Calculator.Services;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weight.Services;

namespace Calculator.Controllers;
 
[Route("api/[controller]")]
[ApiController]
public class AgeController : ControllerBase
{
    private IAgeService ageService;
    public AgeController()
    {   
        this.ageService = new AgeService();
    }

    /// <summary>
    /// Calculates the current age based off of an individual's birth date.
    /// </summary>
    /// <param name="birthYear">Year of birth</param>
    /// <param name="birthMonth">Month of birth</param>
    /// <param name="birthDay">Day of birth</param>
    /// <returns>An object containing the age in different units.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     birthYear: 1980
    ///     birthMonth: 08
    ///     birthDay: 01
    ///     
    /// </remarks>
    /// <response code="200">Returns the Age if given a valid birth date.</response>
    /// <response code="400">Returns an Error object if the date is out of range or invalid.</response>
    [HttpGet]
    [Route("GetAge")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<AgeResponseDto>> GetAge(int birthYear, int birthMonth, int birthDay)
    {
        ServiceResponse<AgeResponseDto> response = this.ageService.GetAge(birthYear, birthMonth, birthDay, null, null, null);

        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Calculates the current age based off of an individual's birth date.
    /// </summary>
    /// <param name="birthYear">Year of birth</param>
    /// <param name="birthMonth">Month of birth</param>
    /// <param name="birthDay">Day of birth</param>
    /// <returns>An object containing the age in different units.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     birthYear: 1980
    ///     birthMonth: 08
    ///     birthDay: 01
    ///     
    /// </remarks>
    /// <response code="200">Returns the Age if given a valid birth date.</response>
    /// <response code="400">Returns an Error object if the date is out of range or invalid.</response>
    [HttpGet]
    [Route("GetAgeOnDate")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<AgeResponseDto>> GetAgeOnDate(int birthYear, int birthMonth, int birthDay,
        int onYear, int onMonth, int onDay)
    {
        ServiceResponse<AgeResponseDto> response = this.ageService.GetAge(birthYear, birthMonth, birthDay,
            onYear, onMonth, onDay);

        if (!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }
}