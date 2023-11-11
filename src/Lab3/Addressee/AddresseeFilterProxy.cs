using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class AddresseeFilterProxy : IAddressee
{
    private IAddressee? _addressee;
    private int _possibleImportanceLevel;

    public AddresseeFilterProxy(IAddressee? addressee, int possibleImportanceLevel)
    {
        _addressee = addressee;
        _possibleImportanceLevel = possibleImportanceLevel;
    }

    public void SendMsg(Message message)
    {
        if (message != null && _addressee != null && Validate(message.ImportanceLevel, _possibleImportanceLevel))
            _addressee.SendMsg(message);
    }

    private static bool Validate(int x, int y)
    {
        return x <= y;
    }
}