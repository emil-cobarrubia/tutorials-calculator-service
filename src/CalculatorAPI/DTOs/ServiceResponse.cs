namespace Calculator.DTOs;

public class ServiceResponse<T>
{
    public T Data { get; set; }

    public ErrorResponseDto? Error {get; set;}

    public bool Success => Error == null;
}


