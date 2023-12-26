using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;

namespace BokingManagementApp.Repository
{
    public class RoleRepository : BaseRepository<Role>,IRoleRepository
    {
        public RoleRepository(BookingContext context) : base(context)
        {
        }
        public Role? GetByName(string name)
        {
            return _context.Set<Role>().FirstOrDefault(role => role.Name == name);
        }
    }
}
