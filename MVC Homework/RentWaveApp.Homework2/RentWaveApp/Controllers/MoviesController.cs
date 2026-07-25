using Microsoft.AspNetCore.Mvc;
using RentWaveApp.Mapper;
using RentWaveApp.Models.ViewModels;
using RentWaveApp.Services.Interfaces;

namespace RentWaveApp.Controllers
{
    [Route("movies")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult GetAllMovies()
        {
            var movies = _movieService.GetAllMovies();
            return View(movies);
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            MovieVM movieVM = _movieService.GetMovieById(id);

            if (movieVM == null)
            {
                return NotFound();
            }
            return View("~/Views/Movies/Partial/_MovieDetailsPartial.cshtml", movieVM);
        }
    }
}
