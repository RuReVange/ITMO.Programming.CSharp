namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public class Message
{
    public Message(string header, string body, int importanceLevel)
    {
        Header = header;
        Body = body;
        ImportanceLevel = importanceLevel;
    }

    public string Header { get; init; }
    public string Body { get; init; }
    public int ImportanceLevel { get; init; }
}