using Microsoft.EntityFrameworkCore;
using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;

namespace RentWaveApp.DataAccess.Imlementations
{
    public class RentalRepository : IRepository<Rental>
    {
        private readonly RentWaveDbContext _context;

        public RentalRepository(RentWaveDbContext context)
        {
            _context = context;
        }

        public void Create(Rental entity)
        {
            _context.Rentals.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var rental = GetById(id);
            if (rental != null)
            {
                _context.Rentals.Remove(rental);
                _context.SaveChanges();
            }
        }

        public List<Rental> GetAll()
        {
            var rentals = _context.Rentals
                .Include(x => x.User)
                .Include(x => x.Movie)
                .ToList();
            return rentals;
        }

        public Rental GetById(int id)
        {
            var rental = _context.Rentals.FirstOrDefault(x => x.Id == id);
            return rental;
        }

        public void Update(Rental entity)
        {
            _context.Rentals.Update(entity);
            _context.SaveChanges();
        }
    }
}
