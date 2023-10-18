namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class FormFactor
{
    public FormFactor(int length = default, int width = default, int height = default)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public int Length { get; init; }
    public int Width { get; init; }
    public int Height { get; init; }
}