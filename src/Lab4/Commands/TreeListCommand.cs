using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.DataContext;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class TreeListCommand : ICommand
{
    private string _path;
    private int _depth;
    private char _indentionSymbol;
    private string _fileSymbols;
    private string _catalogSymbols;

    public TreeListCommand(int depth = 1, char indentionSymbol = ' ', string fileSymbol = "file: ", string catalogSymbols = "catalog: ")
    {
        _path = Directory.GetCurrentDirectory();
        _depth = depth;
        _indentionSymbol = indentionSymbol;
        _fileSymbols = fileSymbol;
        _catalogSymbols = catalogSymbols;
    }

    public void Execute()
    {
        Context.ResultCommandString.Clear();
        ListDirectory(_path, _depth);
    }

    private void ListDirectory(string path, int depth, int indention = 0)
    {
        if (depth < 0) return;

        foreach (string tmpItem in Directory.GetFileSystemEntries(path))
        {
            Context.ResultCommandString.Append(new string(_indentionSymbol, indention * 2) + (Directory.Exists(tmpItem) ? _catalogSymbols : _fileSymbols) + Path.GetFileName(tmpItem) + "\n");
            if (Directory.Exists(tmpItem))
            {
                ListDirectory(tmpItem, depth - 1, indention + 1);
            }
        }
    }
}

/*- Вывод системного каталога должен быть в виде дерева.
- Параметры выводимого дерева (символы обозначающие файл, папку, символы используемые для отступов должны быть программно параметризуемыми).
- Логика вывода содержимого каталога не должна быть завязана на консоль. (т.е. внутри метода не выводим на консоль, а возвращаем строку с помощью StringBuilder'a)
- Логика вывода содержимого файла не должна быть завязана на консоль.*/