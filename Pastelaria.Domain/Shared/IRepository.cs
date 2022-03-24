using System;
using System.Collections.Generic;

namespace Pastelaria.Domain.Shared
{
    public interface IRepository<T> where T : EntityBase
    {
        bool Insert(T register);
        bool Update(T register);
        bool Remove(Guid id);
        List<T> GetAll();
        T GetById(Guid id);
    }
}
