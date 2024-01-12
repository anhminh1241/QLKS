using Microsoft.AspNetCore.Mvc;

namespace QLKS.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
