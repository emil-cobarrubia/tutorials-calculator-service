using Calculator.DTOs;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class TemperatureService : ITemperatureService
    {
        public ServiceResponse<TemperatureResponseDto> FahrenheitToCelsius(double fahrenheit)
        {
            ServiceResponse<TemperatureResponseDto> response = new ServiceResponse<TemperatureResponseDto>
            {
                Data = new TemperatureResponseDto
                {
                    Fahrenheit = fahrenheit,
                    Celsius = Math.Round((double)((fahrenheit - 32) * ((double)5 / (double)9)), 1)
                }
            };

            return response;
        }

        public ServiceResponse<TemperatureResponseDto> CelsiusToFahrenheit(double celsius)
        {

            ServiceResponse<TemperatureResponseDto> response = new ServiceResponse<TemperatureResponseDto>
            {
                Data = new TemperatureResponseDto
                {
                    Celsius = celsius,
                    Fahrenheit = Math.Round((double)((celsius * ((double)9 / (double)5)) + 32), 1)
                }
            };

            return response;
        }
    }
}
