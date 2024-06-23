using Calculator.DTOs;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class TemperatureService : ITemperatureService
    {
        public TemperatureResponseDto FahrenheitToCelsius(double fahrenheit)
        {
            TemperatureResponseDto response = new TemperatureResponseDto
            {
                Fahrenheit = fahrenheit,
                Celsius = Math.Round((double)((fahrenheit - 32) * ((double)5 / (double)9)), 1)
            };

            return response;
        }

        public TemperatureResponseDto CelsiusToFahrenheit(double celsius)
        {
            TemperatureResponseDto response = new TemperatureResponseDto
            {
                Celsius = celsius,
                Fahrenheit = Math.Round((double)((celsius * ((double)9 / (double)5)) + 32), 1)
            };

            return response;
        }
    }
}
