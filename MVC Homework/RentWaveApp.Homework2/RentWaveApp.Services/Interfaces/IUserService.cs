using RentWaveApp.Domain.Domain;

namespace RentWaveApp.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserByCardNumber(string cardNumber);
    }
}
