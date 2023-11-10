namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public interface IConcreteAddressee : IAddressee
{
    public int PossibleImportanceLevel { get; init; }
}