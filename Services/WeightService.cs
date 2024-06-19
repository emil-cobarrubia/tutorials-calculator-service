using Calculator.Constants;
using Calculator.Enums;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Weight.Services
{
    public class WeightService : IWeightService
    {
        public Object GetWeightOnMoon(double weight, WeightUnit weightUnit)
        {
            var response = new {

                weightOnEarth = weight,
                weightUnit = weightUnit,
                weightOnMoon = (double)(weight * EarthMoonConstants.SurfaceGravityMPerS2) / EarthConstants.SurfaceGravityMPerS2
            };

            return response;
        }

        // public Object GetWeightOnMercury(double? weightPounds)
        // {
        //     double weightKilograms = this.ConvertPoundsToKilograms((double)weightPounds);

        //     var response = new
        //     {
        //         weightPounds = weightPounds,
        //         weightKilograms = weightKilograms,
        //         newtons = newtons
        //     };

        //     return response;
        // }

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
    //Object GetWeightOnMercury(double? weightPounds);

    //Object GetWeightOnVenus(double? weightPounds);

        Object GetWeightOnMoon(double weight, WeightUnit weightUnit);

        //Object GetWeightOnMars(double? weightPounds);

        //Object GetWeightOnJupiter(double? weightPounds);

        //Object GetWeightOnSaturn(double? weightPounds);

        //Object GetWeightOnUranus(double? weightPounds);

        //Object GetWeightOnNeptune(double? weightPounds);

        //Object GetWeightOnPluto(double? weightPounds);

        //Object ConvertPoundsToKg(double? weightPounds)
    }
}
