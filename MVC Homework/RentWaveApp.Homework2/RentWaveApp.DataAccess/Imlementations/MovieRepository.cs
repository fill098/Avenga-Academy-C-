using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;

namespace RentWaveApp.DataAccess.Imlementations
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly RentWaveDbContext _context;

        public MovieRepository(RentWaveDbContext context)
        {
            _context = context;
        }

        public void Create(Movie entity)
        {
            _context.Movies.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var movie = GetById(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }

        public List<Movie> GetAll()
        {
            var movies = _context.Movies.ToList();
            return movies;

        }

        public Movie GetById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            return movie;
        }

        public void Update(Movie entity)
        {
            _context.Movies.Update(entity);
            _context.SaveChanges();
        }
    }
}
