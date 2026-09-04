using MoviesApp.Dto.Dto;

namespace MoviesApp.Services.Interfaces
{
    public interface IMovieService
    {
        Task<List<MovieReadDto>> GetAllAsync(int? genreId, int? year, string? title);
    }
}
