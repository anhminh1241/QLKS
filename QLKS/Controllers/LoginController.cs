﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLKS.Models;
using QLKS.Services;
using System.Threading.Tasks;

namespace QLKS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var result = await _userService.Authenticate(user.Email, user.HashedPassword);

            if (result == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(result);
        }
    }
}
