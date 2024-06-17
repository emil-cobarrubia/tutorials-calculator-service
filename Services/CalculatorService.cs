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

        public Object Multiply(double[] numbers)
        {
            double product = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0 )
                    product = numbers[i];
                else   
                    product = product * numbers[i];
            }

            var response = new { input = string.Join(", ", numbers),
                result = product
            };

            return response;
        }

        public Object Power(double? baseNumber, double? exponent)
        {
            
            var response = new { inputBase = baseNumber,
                exponent = exponent,
                result = Math.Pow((double)baseNumber, (double)exponent)
            };

            return response;
        }
    }

     public interface ICalculatorService
    {
        Object Add(double[]? numbers);
        Object Subtract(double[]? numbers);

        Object Multiply(double[]? numbers);

        Object Power(double? baseNumber, double? exponent);

    }

}