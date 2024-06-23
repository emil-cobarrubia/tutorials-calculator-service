using Calculator.DTOs;
using Calculator.Interfaces;
using Humanizer;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json.Linq;
using NuGet.Common;

namespace Calculator.Services
{
    public class ArithmeticService : IArithmeticService
    {
        public ArithmeticResponseDto Add(double[] numbers)
        {
            ArithmeticResponseDto response = new ArithmeticResponseDto
            {
                Input = string.Join(", ", numbers),
                Result = numbers.Sum()
            };
                    
            return response;
        }

        public ArithmeticResponseDto Subtract(double[] numbers)
        {
            double difference = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0)
                    difference = numbers[i];
                else   
                    difference = difference - (numbers[i]);
            }

            ArithmeticResponseDto response = new ArithmeticResponseDto
            {
                Input = string.Join(", ", numbers),
                Result = difference
            };

            return response;
        }

        public ArithmeticResponseDto Multiply(double[] numbers)
        {
            double product = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0 )
                    product = numbers[i];
                else   
                    product = product * numbers[i];
            }

            ArithmeticResponseDto response = new ArithmeticResponseDto
            {
                Input = string.Join(", ", numbers),
                Result = product
            };

            return response;
        }

        public ArithmeticResponseDto Divide(double[] numbers)
        {
            ArithmeticResponseDto response = new ArithmeticResponseDto();
            response.Input = string.Join(", ", numbers);

            double quotient = 0;

            //Check if 0 in array, as we cannot divide by zero.
            bool existsZero = Array.Exists(numbers, element => element == 0);
            if (existsZero)
                return response;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                    quotient = (double)numbers[i];
                else
                    quotient = (double)quotient / numbers[i];
            }

            response.Result = quotient;

            return response;
        }

        public ArithmeticResponseDto Power(double baseNumber, double exponent)
        {
            ArithmeticResponseDto response = new ArithmeticResponseDto();

            response.Input = "Base: " + baseNumber.ToString() + " Exponent: " + exponent.ToString();
            response.Result = Math.Pow((double)baseNumber, (double)exponent);

            return response;
        }

        public ArithmeticResponseDto LogBase10(double number)
        {
            ArithmeticResponseDto response = new ArithmeticResponseDto
            {
                Success = true
            };

            if(number < 0)
            {
                response.Success = false;
                response.ErrorMessage = "Cannot take the logarithm of a negative number.";
                return response;
            }

            response.Input = number.ToString();
            response.Result = Math.Log10(number);

            return response;
        }
    }
}