using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeLogger : IAddressee
{
    private IAddressee _addressee;
    private Logger _logger;

    public AddresseeLogger(IAddressee addressee, Logger logger)
    {
        _addressee = addressee;
        _logger = logger;
    }

    public void SendMsg(Message message)
    {
        _logger.Log(message, _addressee);
        _addressee.SendMsg(message);
    }
}