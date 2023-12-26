using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;

namespace BokingManagementApp.Repository
{
    public class AccountRepository : BaseRepository<Account>,IAccountRepository
    {
        public AccountRepository(BookingContext context) : base(context)
        {
        }
    }
}
