using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileRenameCommand : ICommand
{
    private string _path;
    private string _name;

    public FileRenameCommand(string path, string name)
    {
        _path = path;
        _name = name;
    }

    public void Execute()
    {
        if (!File.Exists(_path)) return;

        string tmpDirectory = Path.GetDirectoryName(_path) ?? _path;
        string tmpNewPath = tmpDirectory != _path ? Path.Combine(tmpDirectory, _name) : _path;

        File.Move(_path, tmpNewPath);
    }
}