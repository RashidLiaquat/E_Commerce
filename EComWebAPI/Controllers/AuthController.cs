using EComBAL.Services;
using EComDAL.Context;
using EComDAL.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly JWTService _jwtService;
        private readonly DataContext _context;

        public AuthController(JWTService jWTService, DataContext dataContext)
        {
            _context = dataContext;
            _jwtService = jWTService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            if (_context.Users == null)
            {
                return NotFound("User data is not available.");
            }

            var user = _context.Users.FirstOrDefault(x => x.UserName == loginDto.UserName );
            if (user != null && BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password))
            {
                var token = _jwtService.GenerateToken(user.Id.ToString(), user.UserName);
                return Ok(new { Token = token });
               
            }
            return Unauthorized("Invalid username or password.");



        }
    }
}
