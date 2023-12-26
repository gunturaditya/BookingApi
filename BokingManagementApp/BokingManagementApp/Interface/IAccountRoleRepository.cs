using BokingManagementApp.Base;
using BokingManagementApp.Models;

namespace BokingManagementApp.Interface
{
    public interface IAccountRoleRepository : IBaseRepository<AccountRole>
    {
        IEnumerable<AccountRole> GetAccountRolesByAccountGuid(Guid guid);
    }
}
