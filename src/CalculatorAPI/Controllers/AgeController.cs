using Calculator.DTOs;
using Calculator.Services;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weight.Services;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeController : ControllerBase
    {
        private IAgeService ageService;
        public AgeController()
        {
            this.ageService = new AgeService();
        }

        [HttpGet]
        [Route("GetAge")]
        public ActionResult<AgeResponseDto> GetAge(int birthYear, int birthMonth, int birthDay)
        {
            AgeResponseDto response = this.ageService.GetAge(birthYear, birthMonth, birthDay, null, null, null);

            return Ok(response);
        }

        [HttpGet]
        [Route("GetAgeOnDate")]
        public ActionResult<AgeResponseDto> GetAgeOnDate(int birthYear, int birthMonth, int birthDay,
            int onYear, int onMonth, int onDay)
        {
            AgeResponseDto response = this.ageService.GetAge(birthYear, birthMonth, birthDay,
                onYear, onMonth, onDay);

            if (response.Success)
                return Ok(response);
            else
                return BadRequest(response.ErrorMessage);
        }
    }

    
}
