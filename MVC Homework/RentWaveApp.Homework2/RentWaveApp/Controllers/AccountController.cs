using Microsoft.AspNetCore.Mvc;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Models.SessionConstants;
using RentWaveApp.Models.ViewModels;
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
            if (HttpContext.Session.GetInt32(SessionConstants.UserId) != null)
            {
                return RedirectToAction("GetAllMovies", "Movies");
            }
            return View(new LoginVM());
        }

        [HttpPost("login")]
        public IActionResult Login(LoginVM loginVM)
        {
            if (HttpContext.Session.GetInt32(SessionConstants.UserId) != null)
            {
                return RedirectToAction("GetAllMovies", "Movies");
            }

            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            User user = _userService.GetUserByCardNumber(loginVM.CardNumber);

            if (user == null)
            {
                ViewBag.Error = "No user found with that card number.";
                return View(loginVM);
            }

            HttpContext.Session.SetInt32(SessionConstants.UserId, user.Id);

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
