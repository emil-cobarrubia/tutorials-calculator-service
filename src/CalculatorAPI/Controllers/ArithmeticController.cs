using Microsoft.AspNetCore.Mvc;
using Calculator.Services;
using Calculator.Interfaces;
using Weight.Services;
using Calculator.Enums;
using Calculator.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator.Controllers
{
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
        /// The Add() method accepts an array of numbers.  All numbers within the array
        /// will be added together.
        /// </summary>
        /// <param name="numbers">The array of numbers to add.</param>
        /// <returns>The sum of all numbers.</returns>
        /// <response code="200">Returns the converted weight.</response>
        /// <response code="400">If the parameters are incorrect.</response>
        [HttpGet]
        [Route("Add")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> Add([FromQuery] double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Add(numbers);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("Subtract")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> Subtract([FromQuery] double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Subtract(numbers);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("Multiply")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> Multiply([FromQuery] double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Multiply(numbers);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("Divide")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> Divide([FromQuery] double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Divide(numbers);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("Power")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> Power(double baseNumber, double exponent)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Power(baseNumber, exponent);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("SquareRoot")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> SquareRoot(double baseNumber)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Power(baseNumber, 0.5);
            return Ok(response);
        }

        [HttpGet]
        [Route("Square")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> Square(double baseNumber)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.Power(baseNumber, 2);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("LogBase10")]
        public ActionResult<ServiceResponse<ArithmeticResponseDto>> LogBase10(double number)
        {
            ServiceResponse<ArithmeticResponseDto> response = this.arithmeticService.LogBase10(number);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }
    }
}
