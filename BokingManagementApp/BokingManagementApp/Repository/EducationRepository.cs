using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;

namespace BokingManagementApp.Repository
{
    public class EducationRepository : BaseRepository<Education>,IEducationRepository
    {
        public EducationRepository(BookingContext context) : base(context)
        {
        }
    }
}
