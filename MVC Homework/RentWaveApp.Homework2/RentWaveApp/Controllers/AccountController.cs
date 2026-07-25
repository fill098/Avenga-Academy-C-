using Microsoft.AspNetCore.Mvc;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Services.Interfaces;

namespace RentWaveApp.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {

        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/")]
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string cardNumber)
        {
            User user = _userService.GetUserByCardNumber(cardNumber);

            if (user == null)
            {
                ViewBag.Error = "No user found with that card number.";
                return View();
            }

            HttpContext.Session.SetInt32("UserId", user.Id);

            return RedirectToAction("GetAllMovies", "Movies");
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}
