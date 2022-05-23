
namespace Pastelaria.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetByAcessUserAndPassword(Employee value);
    }
}
