using BokingManagementApp.Base;
using BokingManagementApp.Models;

namespace BokingManagementApp.Interface
{
    public interface IRoomRepository : IBaseRepository<Room>
    {
        IEnumerable<Room> GetByName(string name);
    }
}
