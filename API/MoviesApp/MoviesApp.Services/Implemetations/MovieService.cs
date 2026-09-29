using Microsoft.IdentityModel.Tokens;
using MoviesApp.Common.Exceptions;
using MoviesApp.DateAccess.Interfaces;
using MoviesApp.Domain.Domain;
using MoviesApp.Domain.Models;
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


        public async Task<List<MovieReadDto>> GetAllAsync(int? genreId = null, int? year = null, string? title = null)
        {
            var moviesDb = await _moveRepository.GetAllAsync(genreId, year, title);

            List<MovieReadDto> moviesDto = moviesDb.Select(movie => new MovieReadDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                DurationMinutes = movie.DurationMinutes,
                GenreName = movie.Genre.Name,
                DirectorName = movie.Director != null
                ? $"{movie.Director.FirstName} {movie.Director.LastName}" 
                :"Unknown",
                ActorNames = movie.Actors.Where(movie => movie != null).Select(actor => actor.FirstName + " " + actor.LastName).ToList()
            }).ToList();

            return moviesDto;
        }

        public async Task<MovieReadDto> GetById(int id)
        {

            var movieIdDb = await _moveRepository.GetByIdAsync(id);

            if (movieIdDb == null)
            {
                throw new NotFoundException($"Movie with id {id} was not found.");
            }

            MovieReadDto movieDto = new MovieReadDto
            {
                Id = movieIdDb.Id,
                Title = movieIdDb.Title,
                Description = movieIdDb.Description,
                Year = movieIdDb.Year,
                DurationMinutes = movieIdDb.DurationMinutes,
                GenreName = movieIdDb.Genre.Name,
                DirectorName = movieIdDb.Director != null
                ? $"{movieIdDb.Director.FirstName} {movieIdDb.Director.LastName}"
                : "Unknown",
                ActorNames = movieIdDb.Actors.Where(movie => movie != null).Select(actor => actor.FirstName + " " + actor.LastName).ToList()
            };

            return movieDto;

        }

        public async Task<MovieReadDto> CreateAsync(MovieCreateDto createDto)
        {
            // 1. Check GenreId exists — call _genreRepository.GetByIdAsync(createDto.GenreId)
            //    If null, throw new BadRequestException($"...")

            var gereIdResult = await _genreRepository.GetByIdAsync(createDto.GenreId);

            if (gereIdResult == null)
            {
                throw new BadRequestException($"There is no genre with that id: {createDto.GenreId}");
            }

            // 2. Check DirectorId exists — but only IF createDto.DirectorId has a value
            //    (remember, DirectorId is optional — a null DirectorId is fine and needs no check)

            if (createDto.DirectorId.HasValue)
            {
                var directorIdresult = await _directorRepository.GetByIdAsync(createDto.DirectorId.Value);

                if (directorIdresult == null)
                {
                    throw new BadRequestException($"There is no movie director with this id: {createDto.DirectorId.Value}");
                }
            }

            // 3. Check every id in createDto.ActorsId exists
            //    (you'll need to loop or check each one — think about whether one bad id
            //     should stop immediately, or whether you'd want to check them all and
            //     report every bad one at once. Either is defensible; pick one.)
            List<Actor> validatedActors = new List<Actor>();
            foreach (int actorId in createDto.ActorsId)
            {
                var actorResult = await _actorRepository.GetByIdAsync(actorId);
                if (actorResult == null)
                {
                    throw new BadRequestException($"There is no actor with id: {actorId}");
                }
                validatedActors.Add(actorResult);
            }
            // 4. Check Year isn't in the future
            //    if (createDto.Year > DateTime.UtcNow.Year) throw new BadRequestException(...)

            if (createDto.Year > DateTime.UtcNow.Year)
            {
                throw new BadRequestException($"The film can not be created in the future: {createDto.Year}");
            }

            // 5. NOW build the actual Movie entity from the DTO's data
            //    var movie = new Movie { Title = ..., GenreId = ..., ... }
            //    For Actors — you'll need to fetch the actual Actor entities (not just IDs)
            //    to attach to movie.Actors, since that's a List<Actor> navigation property

            var movie = new Movie
            {
                Title = createDto.Title,
                Description = createDto.Description,
                Year = createDto.Year,
                DurationMinutes = createDto.DurationMinutes,
                GenreId = createDto.GenreId,
                DirectorId = createDto.DirectorId,
                Actors = validatedActors
            };


            // 6. Save it — call _movieRepository.AddAsync(movie)

            await _moveRepository.AddAsync(movie);

           
            MovieReadDto movieDto = new MovieReadDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                DurationMinutes = movie.DurationMinutes,
                GenreName = movie.Genre.Name,
                DirectorName = movie.Director != null
                    ? $"{movie.Director.FirstName} {movie.Director.LastName}"
                    : "Unknown",
                ActorNames = movie.Actors.Select(actor => actor.FirstName + " " + actor.LastName).ToList()
            };

            return movieDto;
        }

    }
}
