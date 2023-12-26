using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BokingManagementApp.Repository
{
    public class RoomRepository:BaseRepository<Room>,IRoomRepository
{
    public RoomRepository(BookingContext context) : base(context) { }
    public IEnumerable<Room> GetByName(string name)
    {
        return _context.Set<Room>().Where(room => room.Name.Contains(name));
    }
}

}
