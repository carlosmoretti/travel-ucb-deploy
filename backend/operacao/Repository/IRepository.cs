using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
  public interface IRepository<T> where T : DomainBase
  {
    IEnumerable<T> GetAll();
    T Get(int id);
    void Add(T obj);
    void Update(T obj);
    void Remove(int id);
  }
}
