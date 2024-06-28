using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface IArithmeticService
    {
        ServiceResponse<ArithmeticResponseDto> Add(double[] numbers);
        ServiceResponse<ArithmeticResponseDto> Subtract(double[] numbers);
        ServiceResponse<ArithmeticResponseDto> Multiply(double[] numbers);
        ServiceResponse<ArithmeticResponseDto> Divide(double[] numbers);
        ServiceResponse<ArithmeticResponseDto> LogBase10(double number);
        ServiceResponse<ArithmeticResponseDto> Power(double baseNumber, double exponent);
    }
}
