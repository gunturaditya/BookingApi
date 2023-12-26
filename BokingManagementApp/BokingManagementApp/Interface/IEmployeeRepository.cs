using BokingManagementApp.Base;
using BokingManagementApp.Models;

namespace BokingManagementApp.Interface
{
    public interface IEmployeeRepository :IBaseRepository<Employee>
    {
        IEnumerable<Employee> GetByFirstName(string name);

        Employee? GetByEmail(string email);

        public Employee? GetByEmailAndPhoneNumber(string data);
    }
}
