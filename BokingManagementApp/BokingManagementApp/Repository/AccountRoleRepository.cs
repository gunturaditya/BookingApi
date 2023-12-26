using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;

namespace BokingManagementApp.Repository
{
    public class AccountRoleRepository : BaseRepository<AccountRole>,IAccountRoleRepository
    {
        public AccountRoleRepository(BookingContext context) : base(context)
        {
        }
        public IEnumerable<AccountRole> GetAccountRolesByAccountGuid(Guid guid)
        {
            return _context.Set<AccountRole>().Where(ar => ar.AccountGuid == guid);
        }
    }
}
