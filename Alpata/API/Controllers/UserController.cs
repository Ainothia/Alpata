using Alpata.API.Business.Interfaces;
using Alpata.Entity;
using Alpata.Model;
using Microsoft.AspNetCore.Mvc;

namespace Alpata.Controllers;

[ApiController]
[Route("user")]
public class UserController : Controller
{
	private readonly IUserService _userService;

	public UserController(IUserService userService)
	{
		_userService = userService;
	}

    [HttpPost("save")]
    [ProducesDefaultResponseType(typeof(bool))]
    public bool Save([FromForm] SaveUserRequestDto saveUserRequestDto)
    {
        return _userService.Save(saveUserRequestDto);
    }

    [HttpPost("login")]
    [ProducesDefaultResponseType(typeof(User))]
    public User Login([FromBody] LoginRequestDto loginRequestDto)
    {
        return _userService.Login(loginRequestDto);
    }
}


