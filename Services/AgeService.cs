namespace Calculator.Services
{
    public class AgeService : IAgeService
    {
        public Object GetAge(int? birthYear, int? birthMonth, int? birthDay,
            int? onYear, int? onMonth, int? onDay)
        {
            DateTime now = DateTime.Now;

            onYear = (onYear == null) ? now.Year : onYear;
            onMonth = (onMonth == null) ? now.Month : onYear;
            onDay = (onDay == null) ? now.Day : onDay;

            DateTime onDate = new DateTime((int)onYear, (int)onMonth, (int)onDay);
            DateTime birthDate = new DateTime((int)birthYear, (int)birthMonth, (int)birthDay);

            TimeSpan span = onDate.Subtract(birthDate);

            int years = (int)Math.Floor(span.TotalDays / 365);
            int days = (int)Math.Floor(span.TotalDays);
            int hours = (int)span.TotalMinutes / 60;
            int minutes = (int)span.TotalMinutes;
            int seconds = (int)span.TotalSeconds;

            var response = new
            {

                inputs = new
                {
                    birthYear = birthYear,
                    birthMonth = birthMonth,
                    birthDay = birthDay
                },

                age = new
                {
                    years = years,
                    days = days,
                    hours = hours,
                    minutes = minutes,
                    seconds = seconds
                }
            };

            return response;
        }
    }

    public interface IAgeService
    {
        Object GetAge(int? birthYear, int? birthMonth, int? birthDay,
            int? onYear, int? onMonth, int? onDay);
    }
}
