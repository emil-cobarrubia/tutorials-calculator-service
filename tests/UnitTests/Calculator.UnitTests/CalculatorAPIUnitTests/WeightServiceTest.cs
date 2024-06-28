using Calculator.DTOs;
using Calculator.Services;
using Weight.Services;
namespace CalculatorAPIUnitTests;

public class WeightServiceTest
{
    [Fact]
    public void Weight_On_Moon_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.1666;
        
        //Act
        WeightResponseDto response = testCase.GetWeightOnMoon(1, null);

        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Weight, 2));
    }

    [Fact]
    public void Weight_On_Mercury_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.3773;

        //Act
        WeightResponseDto response = testCase.GetWeightOnMercury(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Weight, 2));
    }
}
