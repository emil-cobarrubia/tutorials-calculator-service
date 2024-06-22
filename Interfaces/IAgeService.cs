using Calculator.DTOs;

namespace Calculator.Interfaces
{
    public interface IAgeService
    {
        AgeResponseDto GetAge(int birthYear, int birthMonth, int birthDay,
            int? onYear, int? onMonth, int? onDay);
    }
}
