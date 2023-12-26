using BokingManagementApp.Base;
using BokingManagementApp.Context;
using BokingManagementApp.Dto.Boking;
using BokingManagementApp.Interface;
using BokingManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BokingManagementApp.Repository
{
    public class BookingRepository : BaseRepository<Booking>,IBokingRepository
    {
        public BookingRepository(BookingContext context) : base(context)
        {
        }

        public IEnumerable<BookingDetailDto> GetBookingDetails()
        {
            var booking = _context.Bookings
                .Include(b => b.Room)
                .Include(b => b.Employee)
                .Where(b => b.Room.Guid == b.Room.Guid && b.Employee.Guid == b.Employee.Guid)
                .ToList();

            var bookingDetails = booking.Select(b => new BookingDetailDto
            {
                Guid = b.Guid,
                BookedNik = b.Employee.Nik,
                BookedBy = b.Employee.FirstName + " " + b.Employee.LastName,
                RoomName = b.Room.Name,
                StartDate = b.StartDate,
                EndDate = b.EndDate,
                Status = b.Status,
                Remarks = b.Remarks
            });
            return bookingDetails;
        }
    }
}
