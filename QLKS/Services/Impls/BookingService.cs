using QLKS.Models;
using QLKS.Repositories.Interfaces;

namespace QLKS.Services.Impls
{
    public class BookingService
    {
        private readonly IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;

            //public async Task Create(Room room)
            //{
            //    await _roomRepo.Add(room);
            //}

            //public Task<List<Room>> GetAllRoom()
            //{
            //    return _roomRepo.FindAll().ToListAsync();
            //}
        }
    }
}
