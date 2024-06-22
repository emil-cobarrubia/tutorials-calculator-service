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
        public ActionResult<ArithmeticResponseDto> Add([FromQuery] double[] numbers)
        {
            ArithmeticResponseDto response = this.arithmeticService.Add(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Subtract")]
        public ActionResult<ArithmeticResponseDto> Subtract([FromQuery] double[] numbers)
        {
            ArithmeticResponseDto response = this.arithmeticService.Subtract(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Multiply")]
        public ActionResult<ArithmeticResponseDto> Multiply([FromQuery] double[] numbers)
        {
            ArithmeticResponseDto response = this.arithmeticService.Multiply(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Power")]
        public ActionResult<ArithmeticResponseDto> Power(double baseNumber, double exponent)
        {
            ArithmeticResponseDto response = this.arithmeticService.Power(baseNumber, exponent);
            return Ok(response);
        }

        [HttpGet]
        [Route("SquareRoot")]
        public ActionResult<ArithmeticResponseDto> SquareRoot(double baseNumber)
        {
            ArithmeticResponseDto response = this.arithmeticService.Power(baseNumber, 0.5);
            return Ok(response);
        }

        [HttpGet]
        [Route("Square")]
        public ActionResult<ArithmeticResponseDto> Square(double baseNumber)
        {
            ArithmeticResponseDto response = this.arithmeticService.Power(baseNumber, 2);
            return Ok(response);
        }
    }
}
