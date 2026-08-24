using RentWaveApp.Domain.Domain;
using RentWaveApp.Models.Dtos;
using RentWaveApp.Models.ViewModels;

namespace RentWaveApp.Mapper
{
    public static class RentWaveMapper
    {
        public static MovieVM MapToMovieVM(Movie movie)
        {
            return new MovieVM
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre.ToString(),
                Language = movie.Language.ToString(),
                IsAvailable = movie.IsAvailable,
                Quantity = movie.Quantity,
                ReleaseDate = movie.ReleaseDate,
                Length = movie.Length,

            };
        }

        public static Rental MapToRental(RentalDto rentalDtos)
        {
            return new Rental
            {
                MovieId = rentalDtos.MovieId,
                UserId = rentalDtos.UserId,
                RentedOn = DateTime.Now,
            };
        }
        public static RentalVM MapToRentalVM(Rental rental, Movie movie)
        {
            return new RentalVM
            {
                RentalId = rental.Id,
                MovieTitle = movie.Title,
                RentedOn = rental.RentedOn
            };
        }
    }
}
