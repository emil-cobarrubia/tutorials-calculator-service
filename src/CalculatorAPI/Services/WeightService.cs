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
            
            double conversionFactor = (double) surfaceGravityMPerS2 / EarthConstants.SurfaceGravityMPerS2;
            response.Data = new WeightResponseDto
            {
                Weight = weight * conversionFactor,
                Planet = planet,
                ConversionFactor = conversionFactor
            };

            return response;
        }

        public ServiceResponse<WeightResponseDto> GetWeightConversionFactorForPlanet(string planet)
        {
            ServiceResponse<WeightResponseDto> response = new ServiceResponse<WeightResponseDto>();
            double surfaceGravityMPerS2;

            switch(planet.ToUpper())
            {
                case Planets.Mercury:
                    surfaceGravityMPerS2 = MercuryConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Venus:
                    surfaceGravityMPerS2 = VenusConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Earth:
                    surfaceGravityMPerS2 = EarthConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Mars:
                    surfaceGravityMPerS2 = MarsConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Jupiter:
                    surfaceGravityMPerS2 = JupiterConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Saturn:
                    surfaceGravityMPerS2 = SaturnConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Uranus:
                    surfaceGravityMPerS2 = UranusConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Neptune:
                    surfaceGravityMPerS2 = NeptuneConstants.SurfaceGravityMPerS2;
                break;

                case Planets.Pluto:
                    surfaceGravityMPerS2 = PlutoConstants.SurfaceGravityMPerS2;
                break;

                default:
                    surfaceGravityMPerS2 = -1;
                break;
            }

            //Invalid selection
            if(surfaceGravityMPerS2 < 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Invalid planet selected.  Cannot compute conversion factor."
                };

                return response;
            }

            response.Data = new WeightResponseDto
            {
                ConversionFactor = (double) surfaceGravityMPerS2 / EarthConstants.SurfaceGravityMPerS2
            };

            return response;
        }
    }
}
