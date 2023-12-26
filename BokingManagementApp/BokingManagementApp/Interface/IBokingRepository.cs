using BokingManagementApp.Base;
using BokingManagementApp.Dto.Boking;
using BokingManagementApp.Models;

namespace BokingManagementApp.Interface
{
    public interface IBokingRepository: IBaseRepository<Booking>
    {
        IEnumerable<BookingDetailDto> GetBookingDetails();
    }
}
