using Microsoft.EntityFrameworkCore;
using RentWaveApp.Models.Domain;
using RentWaveApp.Models.Enums;

namespace RentWaveApp.DataAccess
{
    public class RentWaveDataContext : DbContext
    {
        public RentWaveDataContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seedDate = new DateTime(2024, 1, 1);

            var subscriptions = new List<Subscription>
            {
                new Subscription { Id = 1, CreatedOn = seedDate, Name = "Basic", IsSubscript = true },
                new Subscription { Id = 2, CreatedOn = seedDate, Name = "Premium", IsSubscript = true }
            };

            var users = new List<User>
            {
                new User { Id = 1, CreatedOn = seedDate, FullName = "Ana Petrova", Age = 28, CardNumber = "1111-2222", IsSubscriptionExpired = false, SubscriptionId = 1 },
                new User { Id = 2, CreatedOn = seedDate, FullName = "Marko Ivanov", Age = 34, CardNumber = "3333-4444", IsSubscriptionExpired = false, SubscriptionId = 2 }
            };

            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1, CreatedOn = seedDate, Title = "The Last Signal",
                    GenreName = Genre.SciFi, LanguageName = Language.English, IsAvailable = true,
                    ReleaseDate = new DateTime(2021, 5, 10), Length = new TimeSpan(2, 5, 0),
                    AgeRestriction = 13, Quantity = 3
                },
                new Movie
                {
                    Id = 2, CreatedOn = seedDate, Title = "Bakery on Elm Street",
                    GenreName = Genre.Comedy, LanguageName = Language.English, IsAvailable = true,
                    ReleaseDate = new DateTime(2019, 11, 2), Length = new TimeSpan(1, 45, 0),
                    AgeRestriction = 0, Quantity = 5
                }
            };

            var casts = new List<Cast>
            {
                new Cast { Id = 1, CreatedOn = seedDate, MovieId = 1, Name = "James Colton", PartName = Part.Actor },
                new Cast { Id = 2, CreatedOn = seedDate, MovieId = 1, Name = "Lena Ford", PartName = Part.Director },
                new Cast { Id = 3, CreatedOn = seedDate, MovieId = 2, Name = "Priya Shah", PartName = Part.Actor }
            };

            var rentals = new List<Rental>
            {
                new Rental { Id = 1, CreatedOn = seedDate, MovieId = 1, UserId = 1, RentedOn = seedDate.AddDays(-2), ReturnedOn = seedDate.AddDays(-1) }
            };

            modelBuilder.Entity<Subscription>().HasData(subscriptions);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Cast>().HasData(casts);
            modelBuilder.Entity<Rental>().HasData(rentals);

            base.OnModelCreating(modelBuilder);
        }
    }
}