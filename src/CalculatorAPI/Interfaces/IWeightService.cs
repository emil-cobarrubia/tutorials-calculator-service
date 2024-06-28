using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface IWeightService
    {
        ServiceResponse<WeightResponseDto> GetWeightOnMoon(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnMercury(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnVenus(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnMars(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnJupiter(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnSaturn(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnUranus(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnNeptune(double weight, string? unit);
        ServiceResponse<WeightResponseDto> GetWeightOnPluto(double weight, string? unit);
    }
}
