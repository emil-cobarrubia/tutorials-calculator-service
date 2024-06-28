using Calculator;
using Calculator.DTOs;
using Calculator.Services;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CalculatorAPIUnitTests
{
    public class ArithmeticServiceTest
    {
        [Fact]
        public void LogBase10_10_Return_1()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();
            double expected = 1;

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.LogBase10(10);

            //Assert
            Assert.Equal(expected, response.Data.Result);
        }

        [Fact]
        public void LogBase10_NegativeInput_Return_Error()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();
            bool expected = false;

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.LogBase10(-10);

            //Assert
            Assert.Equal(expected, response.Success);
        }

        [Fact]
        public void Add_Empty_Return_Error()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();
            bool expected = false;

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Add([]);

            //Assert
            Assert.Equal(expected, response.Success);
        }

        [Theory]
        [InlineData(new double [] { 3, 4 }, 7)]
        [InlineData(new double[] { 5 }, 5)]
        [InlineData(new double[] { 324235, 32623, 3474566.3463, 3474, 567.3245, -32434, -24356.4232, 0 }, 3778675.248)]
        public void Add_N_Numbers_Return_Sum(double[] numbers, double expected)
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Add(numbers);

            //Assert
            Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Result, 2));
        }

        [Fact]
        public void Subtract_Empty_Return_Error()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();
            bool expected = false;

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Subtract([]);

            //Assert
            Assert.Equal(expected, response.Success);
        }

        [Theory]
        [InlineData(new double[] { 10, 4 }, 6)]
        [InlineData(new double[] { 324235, 21, 54, -45, -24356.4232, 0 }, 348561.4232)]
        [InlineData(new double[] { 100, 3, 4, -5, -1, 0 }, 99)]
        [InlineData(new double[] { 1 }, 1)]
        public void Subtract_N_Numbers_Return_Difference(double[] numbers, double expected)
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Subtract(numbers);

            //Assert
            Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Result, 2));
        }

        [Fact]
        public void Multiply_Empty_Return_Error()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();
            bool expected = false;

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Multiply([]);

            //Assert
            Assert.Equal(expected, response.Success);
        }

        [Theory]
        [InlineData(new double[] { 1, 544, 0}, 0)]
        [InlineData(new double[] { 5 }, 5)]
        [InlineData(new double[] { 3 }, 3)]
        [InlineData(new double[] { 0 }, 0)]
        [InlineData(new double[] { -1, -1 }, 1)]
        [InlineData(new double[] { -1, 1 }, -1)]
        [InlineData(new double[] { 5, 3, 25, -1, -4 }, 1500)]
        public void Multiply_N_Numbers_Return_Product(double[] numbers, double expected)
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Multiply(numbers);

            //Assert
            Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Result,2));
        }

        [Fact]
        public void Divide_Empty_Return_Error()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();
            bool expected = false;

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Divide([]);

            //Assert
            Assert.Equal(expected, response.Success);
        }

        [Theory]
        [InlineData(new double[] { 1, 2 }, 0.5)]
        [InlineData(new double[] { 4, 2 }, 2)]
        [InlineData(new double[] { 5, 1 }, 5)]
        [InlineData(new double[] { 5 }, 5)]
        
        public void Divide_N_Numbers_Return_Quotient(double[] numbers, double expected)
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Divide(numbers);

            //Assert
            Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Result, 2));
        }

        [Fact]
        public void Divide_EmptyArray_Error()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService(); 
            bool expected = false;
    
            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Divide([]);

            //Assert
            Assert.Equal(expected, response.Success);
        }

        [Fact]
        public void Divide_ByZero_Error()
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService(); 
            bool expected = false;
    
            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Divide([1, 0]);

            //Assert
            Assert.Equal(expected, response.Success);
        }

        [Theory]
        [InlineData(1,1,1)]
        [InlineData(1000, 0, 1)]
        [InlineData(10, 2, 100)]
        [InlineData(100, 0.5, 10)]
        public void Power_Return_Product(double baseNumber, double exponent, double expected)
        {
            //Arrange
            ArithmeticService testCase = new ArithmeticService();

            //Act
            ServiceResponse<ArithmeticResponseDto> response = testCase.Power(baseNumber, exponent);

            //Assert
            Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Result, 2));
        }
    }
}