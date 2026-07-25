using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;
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
        public List<MovieVM> GetAllMovies()
        {
            List<Movie> movies = _movieRepository.GetAll();

            List<MovieVM> moviesVM = movies
                .Select(movie => RentWaveMapper.MapToMovieVM(movie))
                .ToList();

            return moviesVM;
        }

        public MovieVM GetMovieById(int id)
        {
            var movie = _movieRepository.GetById(id);
            var movieVM = RentWaveMapper.MapToMovieVM(movie);
            return movieVM;
        }
    }
}
