using QLKS.DbContext;
using QLKS.Models;
using QLKS.Repositories.Interfaces;

namespace QLKS.Repositories
{
    public class RoomTypeRepo : BaseRepo<RoomType, int>, IRoomTypeRepo { 
        public RoomTypeRepo(AppDbContext context) : base(context)
        {
        }
    }
}
