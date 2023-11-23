namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components.AuxiliaryComponents;

public class FormFactor
{
    public FormFactor(int length = default, int height = default, int width = default)
    {
        Length = length;
        Height = height;
        Width = width;
    }

    public int Length { get; init; }
    public int Height { get; init; }
    public int Width { get; init; }
}