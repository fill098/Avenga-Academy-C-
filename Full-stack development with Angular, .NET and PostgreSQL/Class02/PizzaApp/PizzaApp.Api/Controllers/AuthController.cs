using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Dtos.Auth;
using PizzaApp.Dtos.User;
using PizzaApp.Services.Abstractions;

namespace PizzaApp.Api.Controllers
{
    [AllowAnonymous]
    public class AuthController : ApiControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]

        public async Task<ActionResult<UserDto>> Register(RegisterRequsetDto requset, CancellationToken cancellationToken)
        {
            var user = await _authService.RegisterAsync(requset);
            return StatusCode(StatusCodes.Status201Created, requset);
        }

        [HttpPost("login")]

        public async Task<ActionResult<LoginResponsDto>> LogIn(LoginRequestDto requset, CancellationToken cancellationToken)
        {
            var response = await _authService.LoginAsync(requset);
            return Ok(response);
        }
    }
}
