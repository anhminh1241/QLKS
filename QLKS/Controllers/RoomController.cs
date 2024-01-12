using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLKS.Models;
using QLKS.Services;

namespace QLKS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _roomService.GetAllRoom());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Room room)
        {
            try
            {
                await _roomService.Create(room);
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
            
        }
    }
}
