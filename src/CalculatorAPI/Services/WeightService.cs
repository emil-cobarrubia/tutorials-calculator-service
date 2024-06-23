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
        public WeightResponseDto GetWeightOnMoon(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, EarthMoonConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnMercury(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, MercuryConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnVenus(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, VenusConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnMars(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, MarsConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnJupiter(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, JupiterConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnSaturn(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, SaturnConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnUranus(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, UranusConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnNeptune(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, NeptuneConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        public WeightResponseDto GetWeightOnPluto(double weight, string? unit)
        {
            WeightResponseDto response = new WeightResponseDto
            {
                Weight = this.GetWeightBasedOnGravity(weight, PlutoConstants.SurfaceGravityMPerS2),
                Unit = unit
            };

            return response;
        }

        private double GetWeightBasedOnGravity(double weight, double surfaceGravityMPerS2)
        {
            return (double)(weight * surfaceGravityMPerS2) / EarthConstants.SurfaceGravityMPerS2;
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
