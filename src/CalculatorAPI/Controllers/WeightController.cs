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
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnMoon(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnMoon(weight, null);
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnMercury")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnMercury(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnMercury(weight, null);

            if(!response.Success)
                return BadRequest(response);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnVenus")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnVenus(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnVenus(weight, null);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnMars")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnMars(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnMars(weight, null);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnJupiter")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnJupiter(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnJupiter(weight, null);

            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnSaturn")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnSaturn(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnSaturn(weight, null);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnUranus")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnUranus(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnUranus(weight, null);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnNeptune")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnNeptune(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnNeptune(weight, null);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }

        [HttpGet]
        [Route("GetWeightOnPluto")]
        public ActionResult<ServiceResponse<WeightResponseDto>> GetWeightOnPluto(double weight)
        {
            ServiceResponse<WeightResponseDto> response = this.weightService.GetWeightOnPluto(weight, null);
            
            if(!response.Success)
                return BadRequest(response.Error);
            else
                return Ok(response);
        }
    }
}
