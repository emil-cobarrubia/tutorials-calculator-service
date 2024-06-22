using Calculator.DTOs;
using Calculator.Interfaces;
using Humanizer;
using Microsoft.AspNetCore.Components.Forms;
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
                if(i == 0 )
                    difference = numbers[i];
                else   
                    difference = difference - numbers[i];
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

        public ArithmeticResponseDto Power(double baseNumber, double exponent)
        {
            ArithmeticResponseDto response = new ArithmeticResponseDto
            {
                Input = "Base: " + baseNumber.ToString() + " Exponent: " + exponent.ToString(),
                Result = Math.Pow((double)baseNumber, (double)exponent)
            };

            return response;
        }
    }
}