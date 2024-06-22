using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface ITemperatureService
    {
        TemperatureResponseDto FahrenheitToCelsius(double fahrenheit);

        TemperatureResponseDto CelsiusToFahrenheit(double celsius);
    }
}
