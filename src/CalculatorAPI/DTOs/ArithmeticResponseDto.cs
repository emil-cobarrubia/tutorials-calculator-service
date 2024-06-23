namespace Calculator.DTOs
{
    public class ArithmeticResponseDto
    {
        public object Input { get; set; }

        public double Result { get; set; }
        
        public bool Success {  get; set; }

        public string ErrorMessage { get; set; }
    }
}
