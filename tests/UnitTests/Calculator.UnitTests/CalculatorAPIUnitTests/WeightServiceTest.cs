using Calculator.DTOs;
using Calculator.Services;
using Weight.Services;
namespace CalculatorAPIUnitTests;

public class WeightServiceTest
{
    [Fact]
    public void Weight_On_Moon_Is_OneSixth_Of_Earth()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.1666;
        
        //Act
        WeightResponseDto response = testCase.GetWeightOnMoon(1, null);

        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Weight, 2));
    }
}
