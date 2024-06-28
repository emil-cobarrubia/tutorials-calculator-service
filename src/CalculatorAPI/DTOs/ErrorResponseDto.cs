namespace Calculator.DTOs;
public class ErrorResponseDto
{
    public string? ErrorCode{ get; set; }

    public string? ErrorMessage{ get; set;}

    public DateTime Timestamp { get; set; } = DateTime.Now;
}


