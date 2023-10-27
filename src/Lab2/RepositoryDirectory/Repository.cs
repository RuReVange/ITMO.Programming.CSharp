using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;

public class Repository : IRepository<IComponent>
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

    public void Add(IList<IComponent> list, IComponent item)
    {
        list.Add(item);
    }

    public void Delete(IList<IComponent> list, int index)
    {
        list.RemoveAt(index);
    }
}