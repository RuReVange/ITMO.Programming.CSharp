using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.RepositoryDirectory;

public interface IRepository<T>
    where T : class
{
    void Add(IList<T> list, T item); // добавление объекта
    void Delete(IList<T> list, int index); // удаление объекта по индексу
}