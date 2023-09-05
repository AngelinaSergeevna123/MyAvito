
using BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoeAvito;
using MoeAvito.Models;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserService _userService = new();
    
    [HttpPost(nameof(Login))]
    public async Task<IActionResult> Login([FromForm] string password, string name)
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    [HttpPost(nameof(Register))]
    public async Task<IActionResult> Register([FromForm] RegisterModel user)
    {
        _userService.Register(new(user.Name, user.Password));

        return Ok();
    }
}