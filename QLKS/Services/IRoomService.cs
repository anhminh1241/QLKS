using QLKS.Models;

namespace QLKS.Services
{
    public interface IRoomService
    {
       Task<List<Room>> GetAllRoom(); 
       Task Create(Room room);
       Task Delete(int id);
       Task Update(Room room);

    }
}
