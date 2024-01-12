using QLKS.DbContext;
using QLKS.Models;
using QLKS.Repositories.Interfaces;

namespace QLKS.Repositories
{
    public class BookingRepo : BaseRepo<Booking, int>, IBookingRepo
    {
        public BookingRepo(AppDbContext context) : base(context)
        {
        }
    }
}
