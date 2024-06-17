using Microsoft.AspNetCore.Mvc;
using Calculator.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private ICalculatorService calcService;

        public CalculatorController()
        {
            this.calcService = new CalculatorService();
        }

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
    }
}
