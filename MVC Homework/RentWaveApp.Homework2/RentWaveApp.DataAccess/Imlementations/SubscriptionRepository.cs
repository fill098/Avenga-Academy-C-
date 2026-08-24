using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;

namespace RentWaveApp.DataAccess.Imlementations
{
    public class SubscriptionRepository : IRepository<Subscription>
    {
        private readonly RentWaveDbContext _context;

        public SubscriptionRepository(RentWaveDbContext context)
        {
            _context = context;
        }
        public void Create(Subscription entity)
        {
            _context.Subscriptions.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _context.Subscriptions.Remove(user);
                _context.SaveChanges();
            }
        }

        public List<Subscription> GetAll()
        {
            var subscriptions = _context.Subscriptions.ToList();
            return subscriptions;
        }

        public Subscription GetById(int id)
        {
            var subscription = _context.Subscriptions.FirstOrDefault(x => x.Id == id);
            return subscription;
        }

        public void Update(Subscription entity)
        {
            _context.Subscriptions.Update(entity);
            _context.SaveChanges();
        }
    }
}
