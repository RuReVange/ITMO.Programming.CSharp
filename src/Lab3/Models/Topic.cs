namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public class Topic
{
    public Topic(string name, Message message)
    {
        Name = name;
        Message = message;
    }

    public string Name { get; init; }
    public Message Message { get; init; }

    // adresat передача
}