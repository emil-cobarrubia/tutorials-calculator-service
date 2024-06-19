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
    public class CalculatorController : ControllerBase
    {
        private ICalculatorService calcService;
        private IWeightService weightService;

        public CalculatorController()
        {
            this.calcService = new CalculatorService();
            this.weightService = new WeightService();
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
            var response = this.calcService.Add(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Subtract")]
        public Object Subtract([FromQuery] double[]? numbers)
        {
            var response = this.calcService.Subtract(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Multiply")]
        public Object Multiply([FromQuery] double[]? numbers)
        {
            var response = this.calcService.Multiply(numbers);
            return Ok(response);
        }

        [HttpGet]
        [Route("Power")]
        public Object Power(double? baseNumber, double exponent)
        {
            var response = this.calcService.Power(baseNumber, exponent);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetAge")]
        public Object GetAge(int? birthYear, int? birthMonth, int? birthDay,
            int? onYear, int? onMonth, int? onDay)
        {
            var response = this.calcService.GetAge(birthYear, birthMonth, birthDay,
                onYear, onMonth, onDay);
            return Ok(response);
        }

        [HttpGet]
        [Route("FahrenheitToCelsius")]
        public Object FahrenheitToCelsius(double? fahrenheit)
        {
            var response = this.calcService.FahrenheitToCelsius(fahrenheit);
            return Ok(response);
        }

        [HttpGet]
        [Route("CelsiusToFahrenheit")]
        public Object CelsiusToFahrenheit(double? celsius)
        {
            var response = this.calcService.CelsiusToFahrenheit(celsius);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnMoon")]
        public Object GetWeightOnMoon(double weight, WeightUnit weightUnit)
        {
            var response = this.weightService.GetWeightOnMoon(weight, weightUnit);
            return Ok(response);
        }
    }
}
