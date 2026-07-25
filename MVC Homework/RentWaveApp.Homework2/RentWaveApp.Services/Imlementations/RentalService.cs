using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Mapper;
using RentWaveApp.Models.Dtos;
using RentWaveApp.Models.ViewModels;
using RentWaveApp.Services.Interfaces;
using System.Net.Http.Headers;

namespace RentWaveApp.Services.Imlementations
{
    public class RentalService : IRentalService
    {
        private readonly IRepository<Movie> _movieRepositroy;
        private readonly IRepository<Rental> _rentalRepositroy;

        public RentalService(IRepository<Movie> movieRepositroy, IRepository<Rental> rentalRepositroy)
        {
            _movieRepositroy = movieRepositroy;
            _rentalRepositroy = rentalRepositroy;
        }


        public void RentMovie(RentalDto rentalDto)
        {
            var movie = _movieRepositroy.GetById(rentalDto.MovieId);

            if(movie == null || movie.Quantity <= 0)
            {
                throw new InvalidOperationException("Movie is not available for rent.");
            }

            var rental = RentWaveMapper.MapToRental(rentalDto);

            _rentalRepositroy.Create(rental);

            movie.Quantity -= 1;
            _movieRepositroy.Update(movie);
        }
        public List<RentalVM> GetActiveRentalsForUser(int userId)
        {
            var allRentals = _rentalRepositroy.GetAll();

            var acctiveRentals = allRentals.Where(x => x.UserId == userId && x.ReturnedOn == null)
                .Select(x =>
                {
                    var movie = _movieRepositroy.GetById(x.MovieId);
                    return RentWaveMapper.MapToRentalVM(x, movie);
                })
                .ToList();

            return acctiveRentals;
        }

        public void ReturnMovie(int rentalId)
        {
            var rental = _rentalRepositroy.GetById(rentalId);
            
            if(rental == null || rental.ReturnedOn != null)
            {
                throw new InvalidOperationException("Rental not found or already returned.");
            }

            rental.ReturnedOn = DateTime.Now;
            _rentalRepositroy.Update(rental);

            var movie = _movieRepositroy.GetById(rental.MovieId);
            movie.Quantity += 1;
            _movieRepositroy.Update(movie);
        }
    }
}
