using Microsoft.AspNetCore.Mvc;

namespace RentWaveApp.Controllers
{
    public class RentalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
