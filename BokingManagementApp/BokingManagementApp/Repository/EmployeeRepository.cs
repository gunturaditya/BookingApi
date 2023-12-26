using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BokingManagementApp.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(BookingContext context) : base(context) { }
        public IEnumerable<Employee> GetByFirstName(string name)
        {
            return _context.Set<Employee>().Where(x => x.FirstName.Contains(name));
        }

        public Employee? GetByEmail(string email)
        {
            return _context.Set<Employee>().SingleOrDefault(e => e.Email == email);
        }

        public Employee? GetByEmailAndPhoneNumber(string data)
        {
            return _context.Set<Employee>().FirstOrDefault(e => e.PhoneNumber == data && e.Email == data);
        }
    }

}
