using Microsoft.AspNetCore.Mvc;

namespace RentWaveApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
