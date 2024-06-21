using Microsoft.AspNetCore.Mvc;
using Calculator.Services;
using Weight.Services;
using Calculator.Enums;

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
        public Object Add([FromQuery] double[]? numbers)
        {
            var response = this.arithmeticService.Add(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Subtract")]
        public Object Subtract([FromQuery] double[]? numbers)
        {
            var response = this.arithmeticService.Subtract(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Multiply")]
        public Object Multiply([FromQuery] double[]? numbers)
        {
            var response = this.arithmeticService.Multiply(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Power")]
        public Object Power(double? baseNumber, double exponent)
        {
            var response = this.arithmeticService.Power(baseNumber, exponent);
            return Ok(response);
        }

        [HttpGet]
        [Route("SquareRoot")]
        public Object SquareRoot(double? baseNumber)
        {
            var response = this.arithmeticService.Power(baseNumber, 0.5);
            return Ok(response);
        }

        [HttpGet]
        [Route("Square")]
        public Object Square(double? baseNumber)
        {
            var response = this.arithmeticService.Power(baseNumber, 2);
            return Ok(response);
        }
    }
}
