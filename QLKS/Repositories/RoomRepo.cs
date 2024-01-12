using QLKS.DbContext;
using QLKS.Models;
using QLKS.Repositories.Interfaces;

namespace QLKS.Repositories
{
    public class RoomRepo : BaseRepo<Room, int>, IRoomRepo
    {
        public RoomRepo(AppDbContext context) : base(context)
        {
        }
    }
}
