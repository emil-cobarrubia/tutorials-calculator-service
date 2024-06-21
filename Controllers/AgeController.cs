using Calculator.Services;
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
        public Object GetAge(int? birthYear, int? birthMonth, int? birthDay)
        {
            var response = this.ageService.GetAge(birthYear, birthMonth, birthDay, null, null, null);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetAgeOnDate")]
        public Object GetAgeOnDate(int? birthYear, int? birthMonth, int? birthDay,
            int? onYear, int? onMonth, int? onDay)
        {
            var response = this.ageService.GetAge(birthYear, birthMonth, birthDay,
                onYear, onMonth, onDay);
            return Ok(response);
        }
    }

    
}
