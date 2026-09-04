using Microsoft.EntityFrameworkCore;
using MoviesApp.DateAccess.Data;
using MoviesApp.DateAccess.Interfaces;
using MoviesApp.Domain.Domain;

namespace MoviesApp.DateAccess.Implementaions
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesAppDbContext _context;

        public MovieRepository(MoviesAppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Movie>> GetAllAsync()
        {
            var movies = _context.Movies
                .Include(g => g.Genre)
                .Include(d => d.Director)
                .Include(a => a.Actors)
                .AsQueryable();

            return await movies.ToListAsync();
        }
        public Task<Movie?> GetByIdAsync(int id)
        {
            return _context.Movies
                .Include(g => g.Genre)
                .Include(d => d.Director)
                .Include(a => a.Actors)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task AddAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsynce(Movie movie)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Movie movie)
        {
            await _context.SaveChangesAsync();
        }
    }
}
