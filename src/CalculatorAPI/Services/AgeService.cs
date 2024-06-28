using Calculator.DTOs;
using Calculator.Interfaces;

namespace Calculator.Services;

public class AgeService : IAgeService
{
    public ServiceResponse<AgeResponseDto> GetAge(int birthYear, int birthMonth, int birthDay,
        int? onYear, int? onMonth, int? onDay)
    {
        ServiceResponse<AgeResponseDto> response = new ServiceResponse<AgeResponseDto>();

        DateTime now = DateTime.Now;

        onYear = (onYear == null) ? now.Year : onYear;
        onMonth = (onMonth == null) ? now.Month : onMonth;
        onDay = (onDay == null) ? now.Day : onDay;

        //Validate Acceptable Date.
        

        DateTime onDate = new DateTime((int)onYear, (int)onMonth, (int)onDay);
        DateTime birthDate;

        try
        {
            birthDate = new DateTime((int)birthYear, (int)birthMonth, (int)birthDay);
        }
        catch(ArgumentOutOfRangeException ex)
        {
            response.Error = new ErrorResponseDto
            {
                ErrorMessage = "Invalid date format.  Parameters are out of range."
            };

            return response;
        }
        
        TimeSpan span = onDate.Subtract(birthDate);

        //If Ondate is in the past, return
        if ((double)span.TotalSeconds < 0)
        {
            response.Error = new ErrorResponseDto
            {
                ErrorMessage = "On Date cannot be before the birth date."
            };

            return response;
        }

        response.Data = new AgeResponseDto
        {
            BirthDate = new BirthDateResponseDto
            {
                Year = (int)birthYear,
                Month = (int)birthMonth,
                Day = (int)birthDay
            },
            Age = new AgeUnitsResponseDto
            {
                Years = (int)Math.Floor(span.TotalDays / 365),
                Days = (int)Math.Floor(span.TotalDays),
                Hours = (int)span.TotalMinutes / 60,
                Minutes = (int)span.TotalMinutes,
                Seconds = (int)span.TotalSeconds
            }
        };

        return response;
    }
}

