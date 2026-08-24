using Microsoft.EntityFrameworkCore;
using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;

namespace RentWaveApp.DataAccess.Imlementations
{
    public class UserRepository : IRepository<User>
    {
        private readonly RentWaveDbContext _context;

        public UserRepository(RentWaveDbContext context)
        {
            _context = context;
        }
        public void Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            var users = _context.Users
                 .Include(x => x.Subscription)
                 .ToList();
            return users;
        }

        public User GetById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
        }
    }
}
