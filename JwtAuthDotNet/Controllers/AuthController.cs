using JwtAuthDotNet.Data.Dtos;
using JwtAuthDotNet.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDotNet.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    public static User user = new();
    
    
    [HttpPost("register")]
    public ActionResult<User> Register(UserDto request)
    {
        var hashedPassword = new PasswordHasher<User>()
            .HashPassword(user, request.Password);

        user.Username = request.Username;
        user.PasswordHash = hashedPassword;

        return Ok(user);
    }
    
}