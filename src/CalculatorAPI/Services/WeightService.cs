using Calculator.Constants;
using Calculator.Enums;
using Calculator.Services;
using Calculator.DTOs;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Weight.Services
{
    public class WeightService : IWeightService
    {
        public ServiceResponse<WeightResponseDto> GetWeightOnMoon(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, EarthMoonConstants.SurfaceGravityMPerS2, unit);
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnMercury(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, MercuryConstants.SurfaceGravityMPerS2, unit);;
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnVenus(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, VenusConstants.SurfaceGravityMPerS2, unit);
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnMars(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, MarsConstants.SurfaceGravityMPerS2, unit);
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnJupiter(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, JupiterConstants.SurfaceGravityMPerS2, unit);
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnSaturn(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, SaturnConstants.SurfaceGravityMPerS2, unit);
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnUranus(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, UranusConstants.SurfaceGravityMPerS2, unit);
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnNeptune(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, NeptuneConstants.SurfaceGravityMPerS2, unit);
        }

        public ServiceResponse<WeightResponseDto> GetWeightOnPluto(double weight, string? unit)
        {
            return this.GetWeightBasedOnGravity(weight, PlutoConstants.SurfaceGravityMPerS2, unit);
        }

        private ServiceResponse<WeightResponseDto> GetWeightBasedOnGravity(double weight, double surfaceGravityMPerS2, string? unit)
        {
            ServiceResponse<WeightResponseDto> response = new ServiceResponse<WeightResponseDto>();

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
                Unit = unit
            };

            return response;
        }

        public double ConvertToKilograms(double weight, WeightUnit weightUnit)
        {
            double weightKg = 0;
            switch(weightUnit)
            {
                case WeightUnit.Kilograms:
                    weightKg = weight;
                    break;

                case WeightUnit.Pounds:
                    weightKg = (double)(weight*454)/1000; //1 pound = 454 grams; 1000 grams in 1kg
                    break;

                case WeightUnit.Grams:
                    weightKg = (double)weight / 1000;
                    break;

                case WeightUnit.Tonnes:
                    weightKg = weight * 1000;//1 tonne = 1,000kg
                    break;
            }

            return weightKg;
        }
    }
}
