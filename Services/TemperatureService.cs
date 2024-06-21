namespace Calculator.Services
{
    public class TemperatureService : ITemperatureService
    {
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

    public interface ITemperatureService
    {
        Object FahrenheitToCelsius(double? fahrenheit);

        Object CelsiusToFahrenheit(double? celsius);
    }
}
