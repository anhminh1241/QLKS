using Microsoft.EntityFrameworkCore;
using QLKS.Models;
using QLKS.Repositories;
using QLKS.Repositories.Interfaces;

namespace QLKS.Services.Impls
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }



        public async Task<User> Authenticate(string email, string password)
        {
            // Tìm người dùng bằng email
            var user = await _userRepo.FindAll(x => x.Email == email).FirstOrDefaultAsync();

            // Nếu không tìm thấy người dùng hoặc mật khẩu không đúng, trả về null
            if (user == null || !VerifyPassword(password, user.HashedPassword, user.Salt))
                return null;

            // Nếu tất cả đều hợp lệ, trả về thông tin người dùng
            return user;
        }



        private bool VerifyPassword(string password, string hashedPassword, byte[] salt)
        {
            // Mã hóa mật khẩu được nhập và so sánh với mật khẩu đã mã hóa
            // Giả sử bạn có một phương thức để mã hóa mật khẩu với salt
            var enteredPassword = HashPassword(password, salt);
            return enteredPassword == hashedPassword;
        }

        private string HashPassword(string password, byte[] salt)
        {
            // Tạo một đối tượng HMACSHA256 với salt làm khóa
            using (var hmac = new System.Security.Cryptography.HMACSHA256(salt))
            {
                // Chuyển đổi mật khẩu thành mảng byte
                var passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

                // Mã hóa mật khẩu
                var hashedBytes = hmac.ComputeHash(passwordBytes);

                // Chuyển đổi mảng byte đã mã hóa thành chuỗi hex và trả về
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

    }
}
