using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.DTOs;
using Calculator.Services;

namespace CalculatorAPIUnitTests
{
    public class AgeServiceTest
    {
        [Fact]
        public void GetAge_Normal_Return_Age()
        {
            //Arrange
            AgeService testCase = new AgeService();
            int expected = 100;

            //Act
            ServiceResponse<AgeResponseDto> response = testCase.GetAge(1900, 1, 1, 2000, 1, 1);

            //Assert
            Assert.Equal(expected, response.Data.Age.Years);
        }

        [Fact]
        public void GetAge_OnDate_BeforeBirthDate_Return_Error()
        {
            //Arrange
            AgeService testCase = new AgeService();
            bool expected = false;

            //Act
            ServiceResponse<AgeResponseDto> response = testCase.GetAge(1900, 1, 1, 1800, 1, 1);

            //Assert
            Assert.Equal(expected, response.Success);
        }
    }
}
