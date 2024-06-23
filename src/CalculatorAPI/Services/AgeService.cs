using Calculator.DTOs;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class AgeService : IAgeService
    {
        public AgeResponseDto GetAge(int birthYear, int birthMonth, int birthDay,
            int? onYear, int? onMonth, int? onDay)
        {
            DateTime now = DateTime.Now;

            onYear = (onYear == null) ? now.Year : onYear;
            onMonth = (onMonth == null) ? now.Month : onYear;
            onDay = (onDay == null) ? now.Day : onDay;

            DateTime onDate = new DateTime((int)onYear, (int)onMonth, (int)onDay);
            DateTime birthDate = new DateTime((int)birthYear, (int)birthMonth, (int)birthDay);

            TimeSpan span = onDate.Subtract(birthDate);

            AgeResponseDto response = new AgeResponseDto
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
}
