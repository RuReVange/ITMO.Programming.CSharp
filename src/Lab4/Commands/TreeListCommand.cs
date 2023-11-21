using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class TreeListCommand : ICommand
{
    private string[] _subDirectoryCatalog;
    private string[] _filesCatalog;

    public TreeListCommand()
    {
        _subDirectoryCatalog = Directory.GetDirectories(Directory.GetCurrentDirectory());
        _filesCatalog = Directory.GetFiles(Directory.GetCurrentDirectory());
    }

    public void Execute()
    {
        // for (int i = 0; i < depth; ++i)
        // {
        // }
    }
}

/*- Вывод системного каталога должен быть в виде дерева.
- Параметры выводимого дерева (символы обозначающие файл, папку, символы используемые для отступов должны быть программно параметризуемыми).
- Логика вывода содержимого каталога не должна быть завязана на консоль. (т.е. внутри метода не выводим на консоль, а возвращаем строку с помощью StringBuilder'a)
- Логика вывода содержимого файла не должна быть завязана на консоль.*/