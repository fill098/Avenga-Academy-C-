using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Domain.Enum;
using RentWaveApp.Mapper;
using RentWaveApp.Models.ViewModels;
using RentWaveApp.Services.Interfaces;

namespace RentWaveApp.Services.Imlementations
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;

        public MovieService(IRepository<Movie> movieService)
        {
            _movieRepository = movieService;
        }

        public List<MovieVM> GetAllMovies(Genre? genre, string searchTerm)
        {
            List<Movie> movies = _movieRepository.GetAll();

            if (genre.HasValue)
            {
                movies = movies.Where(x => x.Genre == genre.Value).ToList();
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                movies = movies.Where(x => x.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return movies.Select(RentWaveMapper.MapToMovieVM).ToList();
        }
        public MovieVM GetMovieById(int id)
        {
            var movie = _movieRepository.GetById(id);
            var movieVM = RentWaveMapper.MapToMovieVM(movie);
            return movieVM;
        }
    }
}
