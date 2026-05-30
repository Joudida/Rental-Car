using Microsoft.AspNetCore.Mvc;
using Rentalcarbackend.Data;
using Rentalcarbackend.Models;

namespace Rentalcarbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new
            {
                message = "User registered successfully",
                user = user
            });

        }
        [HttpPost("login")]
        public IActionResult Login(User loginUser)
        {
            var user = _context.Users.FirstOrDefault(u =>
                u.Username == loginUser.Username &&
                u.Password == loginUser.Password);

            if (user == null)
            {
                return Unauthorized(new
                {
                    message = "Invalid username or password"
                });
            }

            return Ok(new
            {
                message = "Login successful",
                user = user
            });
        }
    }
}
    
