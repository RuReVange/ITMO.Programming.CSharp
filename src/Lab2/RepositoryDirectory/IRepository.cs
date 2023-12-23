using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;

public interface IRepository
{
    public void Add<T>(IList<T> list, T item)
        where T : class;

    public void Delete<T>(IList<T> list, int index)
        where T : class;
}