using BokingManagementApp.Base;
using BokingManagementApp.Models;

namespace BokingManagementApp.Interface
{
    public interface IRoleRepository :IBaseRepository<Role>
    {
        Role? GetByName(string name);
    }
}
