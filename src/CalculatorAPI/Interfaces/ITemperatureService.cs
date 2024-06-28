using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface ITemperatureService
    {
        ServiceResponse<TemperatureResponseDto> FahrenheitToCelsius(double fahrenheit);

        ServiceResponse<TemperatureResponseDto> CelsiusToFahrenheit(double celsius);
    }
}
