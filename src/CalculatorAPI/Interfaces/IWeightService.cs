using Calculator.DTOs;
using Calculator.Constants;

namespace Calculator.Interfaces
{
    public interface IWeightService
    {
        ServiceResponse<WeightResponseDto> GetWeightOnPlanet(double weight, string planet);
    }
}
