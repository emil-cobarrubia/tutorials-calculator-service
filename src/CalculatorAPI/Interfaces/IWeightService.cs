using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface IWeightService
    {
        WeightResponseDto GetWeightOnMoon(double weight, string? unit);
        WeightResponseDto GetWeightOnMercury(double weight, string? unit);
        WeightResponseDto GetWeightOnVenus(double weight, string? unit);
        WeightResponseDto GetWeightOnMars(double weight, string? unit);
        WeightResponseDto GetWeightOnJupiter(double weight, string? unit);
        WeightResponseDto GetWeightOnSaturn(double weight, string? unit);
        WeightResponseDto GetWeightOnUranus(double weight, string? unit);
        WeightResponseDto GetWeightOnNeptune(double weight, string? unit);
        WeightResponseDto GetWeightOnPluto(double weight, string? unit);
    }
}
