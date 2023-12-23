using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;

public class Repository : IRepository
{
    private static Repository? _instance;

    private Repository()
    {
        this.Context = new ComponentContext();
    }

    public ComponentContext Context { get; init; }

    public static Repository Instance()
    {
        return _instance ??= new Repository();
    }

    public void Add<T>(IList<T> list, T item)
        where T : class
    {
        list.Add(item); // добавление объекта
    }

    public void Delete<T>(IList<T> list, int index)
        where T : class
    {
        list.RemoveAt(index); // удаление объекта по индексу
    }
}