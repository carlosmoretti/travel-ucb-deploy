using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Impl
{
  public class Repository<T> : IRepository<T> where T : DomainBase
  {
    public virtual void Add(T obj)
    {
      throw new NotImplementedException();
    }

    public virtual T Get(int id)
    {
      throw new NotImplementedException();
    }

    public virtual IEnumerable<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public virtual void Remove(int id)
    {
      throw new NotImplementedException();
    }

    public virtual void Update(T obj)
    {
      throw new NotImplementedException();
    }
  }
}
