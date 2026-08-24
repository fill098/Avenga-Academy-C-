using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Services.Interfaces;

namespace RentWaveApp.Services.Imlementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserByCardNumber(string cardNumber)
        {
            var users = _userRepository.GetAll();
            return users.FirstOrDefault(u => u.CardNumber == cardNumber);
        }
    }
}
