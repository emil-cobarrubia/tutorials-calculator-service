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

        public Object Subtract(double[] numbers)
        {
            double difference = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0 )
                    difference = numbers[i];
                else   
                    difference = difference - numbers[i];
            }

            var response = new { input = string.Join(", ", numbers),
                result = difference
            };

            return response;
        }
    }

     public interface ICalculatorService
    {
        Object Add(double[]? numbers);
        Object Subtract(double[]? numbers);

    }

}