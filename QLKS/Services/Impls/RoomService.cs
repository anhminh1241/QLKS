using Microsoft.EntityFrameworkCore;
using QLKS.Models;
using QLKS.Repositories;
using QLKS.Repositories.Interfaces;

namespace QLKS.Services.Impls
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepo _roomRepo;

        public RoomService(IRoomRepo roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public async Task Create(Room room)
        {
            await _roomRepo.Add(room);
        }

        public Task<List<Room>> GetAllRoom()
        {
            return _roomRepo.FindAll().ToListAsync();
        }
        //public async Task Delete(int id)
        //{
        //    await _roomRepo.Delete(id);
        //}
        //public async Task Update(Room room)
        //{
        //    await _roomRepo.Update(room);
        //}
    }
}
