namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class AntimatterFlareException : System.Exception
{
    public AntimatterFlareException() { }
    public AntimatterFlareException(string message)
        : base(message) { }

    public AntimatterFlareException(string message, System.Exception innerException)
        : base(message, innerException)
    { }
}