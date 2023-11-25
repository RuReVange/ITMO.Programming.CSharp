using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public interface ILogger
{
    void Log(Message message, IAddressee addressee);
}