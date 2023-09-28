namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class FuelShortageException : System.Exception
{
    public FuelShortageException() { }

    public FuelShortageException(string message)
        : base(message) { }

    public FuelShortageException(string message, System.Exception innerException)
        : base(message, innerException)
    { }
}