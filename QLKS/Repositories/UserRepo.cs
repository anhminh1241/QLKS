using QLKS.DbContext;
using QLKS.Models;
using QLKS.Repositories.Interfaces;

namespace QLKS.Repositories
{
    public class UserRepo : BaseRepo<User, int>, IUserRepo
    {
        public UserRepo(AppDbContext context) : base(context)
        {
           
        }
    }
}
