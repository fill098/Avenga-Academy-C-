using Microsoft.AspNetCore.Mvc;
using MoviesApp.Common.Exceptions;
using MoviesApp.Domain.Models;
using MoviesApp.Dto.Dto;
using MoviesApp.Services.Interfaces;

namespace MoviesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MovieReadDto>>> GetAll(int? genreId = null, int? year = null, string? title = null)
        {
            try
            {
                List<MovieReadDto> result = await _movieService.GetAllAsync(genreId, year, title);
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred, please contact the administrator.");
            }
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<MovieReadDto>> GetById(int id)
        {

            try
            {
                MovieReadDto result = await _movieService.GetById(id);
                return Ok(result);  
            }
            catch(NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred, please contact the administrator.");
            }
           
        }

    }
}
