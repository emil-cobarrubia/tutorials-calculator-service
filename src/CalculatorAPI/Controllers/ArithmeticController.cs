using Microsoft.AspNetCore.Mvc;
using Calculator.Services;
using Calculator.Interfaces;
using Weight.Services;
using Calculator.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator.Controllers;

[Route("api/[controller]")]
[ApiController]

/// <summary>
/// This controller can be used to calculate basic arithmetic operations.
/// </summary>
public class ArithmeticController : ControllerBase
{
    private IArithmeticService arithmeticService;
    public ArithmeticController()
    {
        this.arithmeticService = new ArithmeticService();
    }

    /// <summary>
    /// Adds N numbers from an array together and returns the sum.
    /// </summary>
    /// <param name="numbers">Numbers to Add</param>
    /// <returns>Sum of all numbers within the array.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     numbers: [234, 342, 654, 0, -1, 434.45]
    ///     
    /// </remarks>
    /// <response code="200">Returns sum if given a valid array of numbers.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("Add")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> Add([FromQuery] double[] numbers)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Add(numbers);
        
        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Subtracts N numbers from an array together and returns the difference.
    /// The next number within the array is subtracted from the previous.
    /// </summary>
    /// <param name="numbers">Numbers to Subtract</param>
    /// <returns>Difference of numbers within the array.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     numbers: [234, 342, 654, 0, -1, 4343.45]
    ///     
    /// </remarks>
    /// <response code="200">Returns the difference if given a valid array of numbers.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("Subtract")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> Subtract([FromQuery] double[] numbers)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Subtract(numbers);

        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Multiplies N numbers from an array together and returns the product.
    /// </summary>
    /// <param name="numbers">Numbers to Multiply</param>
    /// <returns>Product of numbers within the array.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     numbers: [234, 342, 654, 0, -1, 434.45]
    ///     
    /// </remarks>
    /// <response code="200">Returns the product if given a valid array of numbers.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("Multiply")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> Multiply([FromQuery] double[] numbers)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Multiply(numbers);

        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Divides N numbers from an array together and returns the quotient.
    /// The next number within the array is used to divide the previous number.
    /// </summary>
    /// <param name="numbers">Numbers to Divide</param>
    /// <returns>Quotient of numbers within the array.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     numbers: [234, 342, 654, 0, -1, 434.45]
    ///     
    /// </remarks>
    /// <response code="200">Returns the Quotient if given a valid array of numbers.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("Divide")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> Divide([FromQuery] double[] numbers)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Divide(numbers);

        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Takes a base number, applies an exponent, and returns the product.
    /// </summary>
    /// <param name="baseNumber">Base Number</param>
    /// /// <param name="exponent">Exponent</param>
    /// <returns>Product of baseNumber^exponent.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     baseNumber: 10
    ///     exponent: 2
    ///     
    /// </remarks>
    /// <response code="200">Returns the Product if given a valid base and exponent.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("Power")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> Power(double baseNumber, double exponent)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Power(baseNumber, exponent);
        
        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Computes the square root of a number and returns the product.
    /// </summary>
    /// <param name="baseNumber">Base Number</param>
    /// <returns>Returns the square root of a number.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     baseNumber: 16
    ///     
    /// </remarks>
    /// <response code="200">Returns the Product if given a valid base number.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("SquareRoot")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> SquareRoot(double baseNumber)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Power(baseNumber, 0.5);
        return Ok(response);
    }

    /// <summary>
    /// Computes the square of a number and returns the product.
    /// </summary>
    /// <param name="baseNumber">Base Number</param>
    /// <returns>Returns the square of a number.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     baseNumber: 4
    ///     
    /// </remarks>
    /// <response code="200">Returns the Product if given a valid base number.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("Square")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> Square(double baseNumber)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Power(baseNumber, 2);
        
        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }

    /// <summary>
    /// Computes the log base 10 of a number.
    /// </summary>
    /// <param name="number">Number</param>
    /// <returns>Returns the Log base 10 of a number.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     baseNumber: 10
    ///     
    /// </remarks>
    /// <response code="200">Returns the Product if given a valid base number.</response>
    /// <response code="400">Returns an Error object if array is invalid.</response>
    [HttpGet]
    [Route("LogBase10")]
    [Produces("text/json")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesErrorResponseType(typeof(ErrorResponseDto))]
    public ActionResult<ServiceResponse<ArithmeticResponseDto>> LogBase10(double number)
    {
        ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.LogBase10(number);

        if(!response.Success)
            return BadRequest(response.Error);
        else
            return Ok(response);
    }
}