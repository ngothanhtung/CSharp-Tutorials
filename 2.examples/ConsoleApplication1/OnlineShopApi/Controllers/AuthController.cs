using Microsoft.AspNetCore.Mvc;
using OnlineShopApi.Models;
using OnlineShopApi.Services;

namespace OnlineShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            // Simple hardcoded authentication for demo purposes
            // In production, validate against your user store (database, Active Directory, etc.)
            // For demo, we accept "admin" as username and "password" as password
            if (loginModel.Username == "admin" && loginModel.Password == "password")
            {
                var token = _jwtService.GenerateToken(loginModel.Username);
                return Ok(new { token, expires = DateTime.UtcNow.AddMinutes(60) });
            }

            return Unauthorized(new { message = "Invalid username or password" });
        }
    }
}