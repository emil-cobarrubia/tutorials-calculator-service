using Calculator.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weight.Services;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    /// <summary>
    /// This controller can be used to calculate weight conversions to different units as well
    /// as calculate weights using different gravitational values.
    /// </summary>
    public class WeightController : ControllerBase
    {
        private IWeightService weightService;
        public WeightController()
        {
            this.weightService = new WeightService();
        }

        [HttpGet]
        [Route("GetWeightOnMoon")]
        public Object GetWeightOnMoon(double weight)
        {
            var response = this.weightService.GetWeightOnMoon(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnMercury")]
        public Object GetWeightOnMercury(double weight)
        {
            var response = this.weightService.GetWeightOnMercury(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnVenus")]
        public Object GetWeightOnVenus(double weight)
        {
            var response = this.weightService.GetWeightOnVenus(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnMars")]
        public Object GetWeightOnMars(double weight)
        {
            var response = this.weightService.GetWeightOnMars(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnJupiter")]
        public Object GetWeightOnJupiter(double weight)
        {
            var response = this.weightService.GetWeightOnJupiter(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnSaturn")]
        public Object GetWeightOnSaturn(double weight)
        {
            var response = this.weightService.GetWeightOnSaturn(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnUranus")]
        public Object GetWeightOnUranus(double weight)
        {
            var response = this.weightService.GetWeightOnUranus(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnNeptune")]
        public Object GetWeightOnNeptune(double weight)
        {
            var response = this.weightService.GetWeightOnNeptune(weight);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnPluto")]
        public Object GetWeightOnPluto(double weight)
        {
            var response = this.weightService.GetWeightOnPluto(weight);
            return Ok(response);
        }
    }
}
