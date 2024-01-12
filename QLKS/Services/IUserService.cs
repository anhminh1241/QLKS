
using QLKS.Models;

namespace QLKS.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string hashedPassword);
    }
}
