using Microsoft.IdentityModel.Tokens;
using MoviesApp.DateAccess.Interfaces;
using MoviesApp.Domain.Domain;
using MoviesApp.Dto.Dto;
using MoviesApp.Services.Interfaces;

namespace MoviesApp.Services.Implemetations
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _moveRepository;
        private readonly IActorRepository _actorRepository;
        private readonly IDirectorRepository _directorRepository;
        private readonly IGenreRepository _genreRepository;

        public MovieService(
            IMovieRepository movieRepository,
            IActorRepository actorRepository,
            IDirectorRepository directorRepository,
            IGenreRepository genreRepository)
        {
            _moveRepository = movieRepository;
            _actorRepository = actorRepository;
            _directorRepository = directorRepository;
            _genreRepository = genreRepository;
        }

        public async Task<List<MovieReadDto>> GetAllAsync(int? genreId, int? year, string? title)
        {
            var movies = _moveRepository.GetAllAsync();
            List<Movie> moviesDb = await movies;

            if (genreId.HasValue)
            {
                moviesDb.Where(movie => movie.GenreId == genreId).ToList();
            }

            if (year.HasValue)
            {
                moviesDb.Where(movie => movie.Year == year).ToList();
            }

            if (!title.IsNullOrEmpty())
            {
               moviesDb.Where(movie => movie.Title.Contains(title)).ToList();
            }

            List<MovieReadDto> moviesDto = moviesDb.Select(movie => new MovieReadDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                DurationMinutes = movie.DurationMinutes,
                GenreName = movie.Genre.Name,
                DirectorName = movie.Director.FirstName + " " + movie.Director.LastName,
                ActorNames = movie.Actors.Where(movie => movie != null).Select(actor => actor.FirstName + " " + actor.LastName).ToList()
            }).ToList();

            return moviesDto;
        }

       
    }
}
