using Calculator.DTOs;
using Calculator.Enums;
using Calculator.Interfaces;
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
        public ActionResult<WeightResponseDto> GetWeightOnMoon(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnMoon(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnMercury")]
        public ActionResult<WeightResponseDto> GetWeightOnMercury(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnMercury(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnVenus")]
        public ActionResult<WeightResponseDto> GetWeightOnVenus(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnVenus(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnMars")]
        public ActionResult<WeightResponseDto> GetWeightOnMars(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnMars(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnJupiter")]
        public ActionResult<WeightResponseDto> GetWeightOnJupiter(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnJupiter(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnSaturn")]
        public ActionResult<WeightResponseDto> GetWeightOnSaturn(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnSaturn(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnUranus")]
        public ActionResult<WeightResponseDto> GetWeightOnUranus(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnUranus(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnNeptune")]
        public ActionResult<WeightResponseDto> GetWeightOnNeptune(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnNeptune(weight, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnPluto")]
        public ActionResult<WeightResponseDto> GetWeightOnPluto(double weight)
        {
            WeightResponseDto response = this.weightService.GetWeightOnPluto(weight, null);
            return Ok(response);
        }
    }
}
