namespace Itmo.ObjectOrientedProgramming.Lab3.Services.Modifiers;

public static class ColorModifier
{
    public static string Modify(string value, Color color)
    {
        return color is not null ? Crayon.Output.Rgb(color.R, color.G, color.B).Text(value) : Crayon.Output.Rgb(255, 255, 255).Text(value);
    }
}