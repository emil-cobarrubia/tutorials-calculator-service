using Humanizer;
using NuGet.Common;

namespace Calculator.Services
{
    public class CalculatorService : ICalculatorService
    {
        public Object Add(double[] numbers)
        {
            var response = new { input = string.Join(", ", numbers),
                result = numbers.Sum()
            };

            return response;
        }

        public Object Subtract(double[] numbers)
        {
            double difference = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0 )
                    difference = numbers[i];
                else   
                    difference = difference - numbers[i];
            }

            var response = new { input = string.Join(", ", numbers),
                result = difference
            };

            return response;
        }

        public Object Multiply(double[] numbers)
        {
            double product = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0 )
                    product = numbers[i];
                else   
                    product = product * numbers[i];
            }

            var response = new { input = string.Join(", ", numbers),
                result = product
            };

            return response;
        }

        public Object Power(double? baseNumber, double? exponent)
        {
            
            var response = new { inputBase = baseNumber,
                exponent = exponent,
                result = Math.Pow((double)baseNumber, (double)exponent)
            };

            return response;
        }

        public Object Power(double? baseNumber, double? exponent)
        {

            var response = new
            {
                inputBase = baseNumber,
                exponent = exponent,
                result = Math.Pow((double)baseNumber, (double)exponent)
            };

            return response;
        }

        public Object GetAge(int? birthYear, int? birthMonth, int? birthDay,
            int? onYear, int? onMonth, int? onDay)
        {
            DateTime now = DateTime.Now;

            onYear = (onYear == null) ? now.Year : onYear;
            onMonth = (onMonth == null) ? now.Month : onYear;
            onDay = (onDay == null) ? now.Day : onDay;

            DateTime onDate = new DateTime((int)onYear, (int)onMonth, (int)onDay);
            DateTime birthDate = new DateTime((int)birthYear, (int)birthMonth, (int)birthDay);

            TimeSpan span = onDate.Subtract(birthDate);

            int years = (int)Math.Floor(span.TotalDays/365);
            int days = (int)Math.Floor(span.TotalDays);
            int hours = (int)span.TotalMinutes/60;
            int minutes = (int)span.TotalMinutes;
            int seconds = (int)span.TotalSeconds;

            var response = new { 
                
                inputs = new {
                    birthYear = birthYear,
                    birthMonth = birthMonth,
                    birthDay = birthDay
                },
                
                age = new {
                    years = years,
                    days = days,
                    hours = hours,
                    minutes = minutes,
                    seconds = seconds 
                }
            };

            return response;
        }

        public Object FahrenheitToCelsius(double? fahrenheit)
        {
            var response = new
            {
                inputFahrenheit = fahrenheit,
                celsius = Math.Round((double)((fahrenheit - 32) * ((double)5 / (double)9)), 1)
            };

            return response;
        }

        public Object CelsiusToFahrenheit(double? celsius)
        {
            var response = new
            {
                inputCelsius = celsius,
                fahrenheit = Math.Round((double)((celsius * ((double)9 / (double)5)) + 32), 1)
            };

            return response;
        }
    }

     public interface ICalculatorService
    {
        Object Add(double[]? numbers);
        Object Subtract(double[]? numbers);

        Object Multiply(double[]? numbers);

        Object Power(double? baseNumber, double? exponent);

        Object GetAge(int? birthYear, int? birthMonth, int? birthDay,
            int? onYear, int? onMonth, int? onDay);

        Object FahrenheitToCelsius(double? fahrenheit);

        Object CelsiusToFahrenheit(double? celsius);

    }

}