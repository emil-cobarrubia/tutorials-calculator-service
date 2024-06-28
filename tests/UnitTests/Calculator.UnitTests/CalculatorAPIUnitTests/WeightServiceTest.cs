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
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnMoon(1, null);

        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Mercury_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.3773;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnMercury(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Venus_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.9045;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnVenus(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Mars_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.3794;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnMars(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Jupiter_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 2.5279;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnJupiter(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Saturn_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 1.0646;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnSaturn(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Uranus_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.8861;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnUranus(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Neptune_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 1.1367;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnNeptune(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_On_Pluto_Factor()
    {
        //Arrange
        WeightService testCase = new WeightService();
        double expected = 0.0632;

        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnPluto(1, null);
        
        //Assert
        Assert.Equal(Math.Round(expected, 2), Math.Round(response.Data.Weight, 2));
    }

    [Fact]
    public void Weight_Negative_Error()
    {
        //Arrange
        WeightService testCase = new WeightService();
        bool expected = false;
        
        //Act
        ServiceResponse<WeightResponseDto> response = testCase.GetWeightOnMoon(-1, null);

        //Assert
        Console.WriteLine("Unit Testing Error Response: " + response.Error.ErrorMessage);
        Assert.Equal(expected, response.Success);
    }
}
