using RentWaveApp.Domain.Enum;
using RentWaveApp.Models.ViewModels;

namespace RentWaveApp.Services.Interfaces
{
    public interface IMovieService
    {
        MovieVM GetMovieById(int id);
        List<MovieVM> GetAllMovies(Genre? genre, string searchTerm);
    }
}
