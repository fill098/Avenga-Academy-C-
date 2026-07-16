using Microsoft.AspNetCore.Mvc;

namespace RentWaveApp.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
