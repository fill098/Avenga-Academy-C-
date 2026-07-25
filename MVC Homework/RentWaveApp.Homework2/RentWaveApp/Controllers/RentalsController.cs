using Microsoft.AspNetCore.Mvc;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Models.Dtos;
using RentWaveApp.Models.ViewModels;
using RentWaveApp.Services.Interfaces;

namespace RentWaveApp.Controllers
{
    [Route("rentals")]
    public class RentalsController : Controller
    {
        private readonly IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("{movieId}")]
        public IActionResult Rent(int movieId)
        {
            var rentalDto = new RentalDto
            {
                MovieId = movieId,
                UserId = HttpContext.Session.GetInt32("UserId").Value
            };

            _rentalService.RentMovie(rentalDto);

            return RedirectToAction("GetAllMovies", "Movies");
        }

        [HttpGet("my-rentals")]
        public IActionResult GetMyRentals()
        {
            int userId = HttpContext.Session.GetInt32("UserId").Value;
            List<RentalVM> myRentals = _rentalService.GetActiveRentalsForUser(userId);
            return View(myRentals);
        }

        [HttpPost("return/{rentalId}")]

        public IActionResult Return(int rentalId)
        {
            _rentalService.ReturnMovie(rentalId);
            return RedirectToAction("GetMyRentals");
        }
    }
}
