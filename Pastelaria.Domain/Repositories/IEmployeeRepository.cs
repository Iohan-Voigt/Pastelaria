using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetByAcessUserAndPassword(Employee value);
    }
}
