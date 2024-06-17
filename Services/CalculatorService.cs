namespace Calculator.Services
{
    public class CalculatorService : ICalculatorService
    {
        public Object Add(double[] numbers)
        {
            var response = new { input = string.Join(", ", numbers),
                result = numbers.Sum()
            };

            return response;
        }
    }

     public interface ICalculatorService
    {
        Object Add(double[]? numbers);

    }

}