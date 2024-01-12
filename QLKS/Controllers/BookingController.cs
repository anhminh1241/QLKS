using Microsoft.AspNetCore.Mvc;
using QLKS.Services;

namespace QLKS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
