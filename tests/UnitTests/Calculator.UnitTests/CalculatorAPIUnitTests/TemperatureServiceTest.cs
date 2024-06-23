using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.DTOs;
using Calculator.Services;

namespace CalculatorAPIUnitTests
{
    public class TemperatureServiceTest
    {
        [Fact]
        public void Input_32_Fahrenheit_Return_0_Celsius()
        {
            //Arrange
            TemperatureService testCase = new TemperatureService();
            double expected = 0;

            //Act
            TemperatureResponseDto response = testCase.FahrenheitToCelsius(32);

            //Assert
            Assert.Equal(expected, Math.Round(response.Celsius));
        }

        [Fact]
        public void Input_0_Celsius_Return_32_Fahrenheit()
        {
            //Arrange
            TemperatureService testCase = new TemperatureService();
            double expected = 32;

            //Act
            TemperatureResponseDto response = testCase.CelsiusToFahrenheit(0);

            //Assert
            Assert.Equal(expected, Math.Round(response.Fahrenheit));
        }
    }
}
