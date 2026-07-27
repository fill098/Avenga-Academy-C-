using Microsoft.AspNetCore.Mvc;
using RentWaveApp.Domain.Enum;
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
        
        [HttpGet("")]
        public IActionResult GetAllMOvies(Genre? genre)
        {
            var movies = _movieService.GetAllMovies(genre, null);
            ViewBag.SelectedGenre = genre;
            return View(movies);
        }

        [HttpPost("filter")]
        public IActionResult FilterByGenre(Genre? genre)
        {
            var movies = _movieService.GetAllMovies(genre, null);
            ViewBag.SelectedGenre = genre;
            return View("GetAllMovies", movies);
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

        [HttpPost("search")]
        public IActionResult SearchMovies(string searchTerm)
        {
            var movies = _movieService.GetAllMovies(null, searchTerm);
            ViewBag.SearchTerm = searchTerm;
            return View("GetAllMovies", movies);
        }

    }
}
