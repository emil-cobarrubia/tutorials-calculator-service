using Calculator.Constants;
using Calculator.Enums;
using Calculator.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Weight.Services
{
    public class WeightService : IWeightService
    {
        public Object GetWeightOnMoon(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, EarthMoonConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnMercury(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, MercuryConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnVenus(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, VenusConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnMars(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, MarsConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnJupiter(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, JupiterConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnSaturn(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, SaturnConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnUranus(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, UranusConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnNeptune(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, NeptuneConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightOnPluto(double weight)
        {
            return this.GetWeightBasedOnGravity(weight, PlutoConstants.SurfaceGravityMPerS2);
        }

        public Object GetWeightBasedOnGravity(double weight, double surfaceGravityMPerS2)
        {
            var response = new {

                weightOnEarth = weight,
                weightOnMoon = (double)(weight * surfaceGravityMPerS2) / EarthConstants.SurfaceGravityMPerS2
            };

            return response;
        }

        public Double ConvertToKilograms(double weight, WeightUnit weightUnit)
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

    public interface IWeightService
    {
        Object GetWeightOnMoon(double weight);
        Object GetWeightOnMercury(double weight);
        Object GetWeightOnVenus(double weight);
        Object GetWeightOnMars(double weight);
        Object GetWeightOnJupiter(double weight);
        Object GetWeightOnSaturn(double weight);
        Object GetWeightOnUranus(double weight);
        Object GetWeightOnNeptune(double weight);
        Object GetWeightOnPluto(double weight);
        Object GetWeightBasedOnGravity(double weight, double surfaceGravityMPerS2);
    }
}
