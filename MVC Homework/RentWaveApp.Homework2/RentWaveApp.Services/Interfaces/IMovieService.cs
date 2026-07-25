using RentWaveApp.Models.ViewModels;

namespace RentWaveApp.Services.Interfaces
{
    public interface IMovieService
    {
        List<MovieVM> GetAllMovies();
        MovieVM GetMovieById(int id);
    }
}
