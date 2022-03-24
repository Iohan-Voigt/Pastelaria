using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.AppService.Shared
{
    public abstract class AppServiceBase<T> where T : EntityBase
    {
        public abstract string Insert(T entity);
        public abstract string Update(T entity);
        public abstract string Delete(T entity);
        public abstract string Exists(Guid Id);
        public abstract T GetById(Guid Id);
        public abstract List<T> GetAll();        
    }
}
