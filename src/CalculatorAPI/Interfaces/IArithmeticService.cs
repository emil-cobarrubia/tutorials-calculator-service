using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface IArithmeticService
    {
        ArithmeticResponseDto Add(double[] numbers);
        ArithmeticResponseDto Subtract(double[] numbers);
        ArithmeticResponseDto Multiply(double[] numbers);
        ArithmeticResponseDto Divide(double[] numbers);
        ArithmeticResponseDto LogBase10(double number);
        ArithmeticResponseDto Power(double baseNumber, double exponent);
    }
}
