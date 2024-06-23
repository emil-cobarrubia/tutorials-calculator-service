namespace Calculator.DTOs
{
    public class AgeResponseDto
    {
        public BirthDateResponseDto BirthDate {get; set;}
        
        public AgeUnitsResponseDto Age { get; set;}

        public bool Success { get; set;}

        public string ErrorMessage { get; set;}
    }
}
