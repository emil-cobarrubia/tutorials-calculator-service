using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface IArithmeticService
    {
        ArithmeticResponseDto Add(double[] numbers);
        ArithmeticResponseDto Subtract(double[] numbers);
        ArithmeticResponseDto Multiply(double[] numbers);
        ArithmeticResponseDto Power(double baseNumber, double exponent);
    }
}
