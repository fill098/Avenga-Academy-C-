using RentWaveApp.Models.Dtos;
using RentWaveApp.Models.ViewModels;

namespace RentWaveApp.Services.Interfaces
{
    public interface IRentalService
    {
        void RentMovie(RentalDto rentalDto);
        List<RentalVM> GetActiveRentalsForUser(int userId);
        void ReturnMovie(int rentalId);
    }
}
