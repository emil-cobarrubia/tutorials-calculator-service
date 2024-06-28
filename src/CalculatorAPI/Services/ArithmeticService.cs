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
        public ServiceResponse<ArithmeticResponseDto> Add(double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = new ServiceResponse<ArithmeticResponseDto>();

            //Check if array is empty
            if(numbers.Length == 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Array cannot be empty."
                };

                return response;
            }

            response.Data = new ArithmeticResponseDto
            {
                Input = string.Join(", ", numbers),
                Result = numbers.Sum()
            };
                    
            return response;
        }

        public ServiceResponse<ArithmeticResponseDto> Subtract(double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = new ServiceResponse<ArithmeticResponseDto>();

            //Check if array is empty
            if(numbers.Length == 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Array cannot be empty."
                };

                return response;
            }

            double difference = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0)
                    difference = numbers[i];
                else   
                    difference = difference - (numbers[i]);
            }

            response.Data = new ArithmeticResponseDto
            {
                Input = string.Join(", ", numbers),
                Result = difference
            };

            return response;
        }

        public ServiceResponse<ArithmeticResponseDto> Multiply(double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = new ServiceResponse<ArithmeticResponseDto>();

            //Check if array is empty
            if(numbers.Length == 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Array cannot be empty."
                };

                return response;
            }

            double product = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0 )
                    product = numbers[i];
                else   
                    product = product * numbers[i];
            }

            response.Data = new ArithmeticResponseDto
            {
                Input = string.Join(", ", numbers),
                Result = product
            };

            return response;
        }

        public ServiceResponse<ArithmeticResponseDto> Divide(double[] numbers)
        {
            ServiceResponse<ArithmeticResponseDto> response = new ServiceResponse<ArithmeticResponseDto>();

            //Check if array is empty
            if(numbers.Length == 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Array cannot be empty."
                };

                return response;
            }

            //Check if 0 in array, as we cannot divide by zero.
            bool existsZero = Array.Exists(numbers, element => element == 0);
            if (existsZero)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Cannot divide by zero."
                };

                return response;
            }

            //Perform Multiplication
            double quotient = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                    quotient = (double)numbers[i];
                else
                    quotient = (double)quotient / numbers[i];
            }

            //Pack results dto into service response dto.
            response.Data = new ArithmeticResponseDto
            {
                Input = string.Join(", ", numbers),
                Result = quotient
            };

            return response;
        }

        public ServiceResponse<ArithmeticResponseDto> Power(double baseNumber, double exponent)
        {
            ServiceResponse<ArithmeticResponseDto> response = new ServiceResponse<ArithmeticResponseDto>
            {
                Data = new ArithmeticResponseDto
                {
                    Input = "Base: " + baseNumber.ToString() + " Exponent: " + exponent.ToString(),
                    Result = Math.Pow((double)baseNumber, (double)exponent)
                }
            };

            return response;
        }

        public ServiceResponse<ArithmeticResponseDto> LogBase10(double number)
        {
            ServiceResponse<ArithmeticResponseDto> response = new ServiceResponse<ArithmeticResponseDto>();

            if(number < 0)
            {
                response.Error = new ErrorResponseDto
                {
                    ErrorMessage = "Cannot take the logarithm of a negative number."
                };

                return response;
            }

            response.Data = new ArithmeticResponseDto
            {
                Input = number.ToString(),
                Result = Math.Log10(number)
            };

            return response;
        }
    }
}