using Calculator.Constants;
using Calculator.Services;
using Calculator.DTOs;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using CalculatorAPI;
using Microsoft.Build.Construction;

namespace Weight.Services
{
    public class WeightService : IWeightService
    {
        public ServiceResponse<WeightResponseDto> GetWeightOnPlanet(double weight, string planet)
        {
            double gravityConstant = 0;

            switch(planet.ToUpper())
            {
                case Planets.Sun:
                    gravityConstant = SunConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Mercury:
                    gravityConstant = MercuryConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Venus:
                    gravityConstant = VenusConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Earth:
                    gravityConstant = EarthConstants.SurfaceGravityMPerS2;
                break;

                case Planets.EarthMoon:
                    gravityConstant = EarthMoonConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Mars:
                    gravityConstant = MarsConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Jupiter:
                    gravityConstant = JupiterConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Saturn:
                    gravityConstant = SaturnConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Uranus:
                    gravityConstant = UranusConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Neptune:
                    gravityConstant = NeptuneConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Pluto:
                    gravityConstant = PlutoConstants.SurfaceGravityMPerS2;
                break;

                default:
                    gravityConstant = -1;
                break;
            }
            

            return this.GetWeightBasedOnGravity(weight, gravityConstant, planet);
        }

        private ServiceResponse<WeightResponseDto> GetWeightBasedOnGravity(double weight, double surfaceGravityMPerS2, string planet)
        {
            ServiceResponse<WeightResponseDto> response = new ServiceResponse<WeightResponseDto>();

            if(surfaceGravityMPerS2 < 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Invalid planet selected."
                };
                
                return response;
            }

            if(weight < 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Weight must be positive."
                };
                
                return response;
            }
            
            response.Data = new WeightResponseDto
            {
                Weight = (double)(weight * surfaceGravityMPerS2) / EarthConstants.SurfaceGravityMPerS2,
                Planet = planet
            };

            return response;
        }
    }
}
