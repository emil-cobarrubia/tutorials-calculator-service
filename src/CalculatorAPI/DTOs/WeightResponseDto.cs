using Calculator.Constants;
using Microsoft.Identity.Client;

namespace Calculator.DTOs;
public class WeightResponseDto
{
    public double Weight { get; set; }
    public string? Unit {  get; set; }
    public double? ConversionFactor { get; set; }
    public string? Planet {get; set;}
}
