using Microsoft.EntityFrameworkCore;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Domain.Enum;

namespace RentWaveApp.DataAccess
{
    public class RentWaveDbContext : DbContext
    {
        public RentWaveDbContext(DbContextOptions options) : base(options) { }
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
                new User { Id = 2, CreatedOn = seedDate, FullName = "Marko Ivanov", Age = 34, CardNumber = "3333-4444", IsSubscriptionExpired = false, SubscriptionId = 2 },
                new User { Id = 3, CreatedOn = seedDate, FullName = "Elena Dimova", Age = 41, CardNumber = "5555-6666", IsSubscriptionExpired = false, SubscriptionId = 1 },
                new User { Id = 4, CreatedOn = seedDate, FullName = "Stefan Kolev", Age = 23, CardNumber = "7777-8888", IsSubscriptionExpired = true, SubscriptionId = 2 }
            };

            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1, CreatedOn = seedDate, Title = "The Last Signal",
                    Genre = Genre.SciFi, Language = Language.English, IsAvailable = true,
                    ReleaseDate = new DateTime(2021, 5, 10), Length = new TimeSpan(2, 5, 0),
                    AgeRestriction = 13, Quantity = 3
                },
                new Movie
                {
                    Id = 2, CreatedOn = seedDate, Title = "Bakery on Elm Street",
                    Genre = Genre.Comedy, Language = Language.English, IsAvailable = true,
                    ReleaseDate = new DateTime(2019, 11, 2), Length = new TimeSpan(1, 45, 0),
                    AgeRestriction = 0, Quantity = 5
                },
                new Movie
                {
                    Id = 3, CreatedOn = seedDate, Title = "Shadows of Kolarov",
                    Genre = Genre.Drama, Language = Language.Russian, IsAvailable = true,
                    ReleaseDate = new DateTime(2018, 3, 22), Length = new TimeSpan(2, 15, 0),
                    AgeRestriction = 16, Quantity = 2
                },
                new Movie
                {
                    Id = 4, CreatedOn = seedDate, Title = "The Silent Attic",
                    Genre = Genre.Horror, Language = Language.English, IsAvailable = true,
                    ReleaseDate = new DateTime(2022, 10, 13), Length = new TimeSpan(1, 38, 0),
                    AgeRestriction = 18, Quantity = 4
                },
                new Movie
                {
                    Id = 5, CreatedOn = seedDate, Title = "Midnight Ledger",
                    Genre = Genre.Thriller, Language = Language.German, IsAvailable = true,
                    ReleaseDate = new DateTime(2020, 7, 4), Length = new TimeSpan(1, 55, 0),
                    AgeRestriction = 15, Quantity = 0
                },
                new Movie
                {
                    Id = 6, CreatedOn = seedDate, Title = "Paper Hearts in Lyon",
                    Genre = Genre.Romance, Language = Language.French, IsAvailable = true,
                    ReleaseDate = new DateTime(2017, 2, 14), Length = new TimeSpan(1, 42, 0),
                    AgeRestriction = 0, Quantity = 6
                },
                new Movie
                {
                    Id = 7, CreatedOn = seedDate, Title = "Realm of Ashenfall",
                    Genre = Genre.Fantasy, Language = Language.English, IsAvailable = true,
                    ReleaseDate = new DateTime(2023, 6, 30), Length = new TimeSpan(2, 32, 0),
                    AgeRestriction = 13, Quantity = 3
                },
                new Movie
                {
                    Id = 8, CreatedOn = seedDate, Title = "Voices of the Reef",
                    Genre = Genre.Documentary, Language = Language.English, IsAvailable = true,
                    ReleaseDate = new DateTime(2016, 9, 18), Length = new TimeSpan(1, 20, 0),
                    AgeRestriction = 0, Quantity = 2
                },
                new Movie
                {
                    Id = 9, CreatedOn = seedDate, Title = "Kaiju Kindergarten",
                    Genre = Genre.Animation, Language = Language.Japanese, IsAvailable = true,
                    ReleaseDate = new DateTime(2021, 4, 1), Length = new TimeSpan(1, 30, 0),
                    AgeRestriction = 0, Quantity = 5
                },
                new Movie
                {
                    Id = 10, CreatedOn = seedDate, Title = "Steel and Sand",
                    Genre = Genre.Action, Language = Language.Spanish, IsAvailable = true,
                    ReleaseDate = new DateTime(2022, 1, 21), Length = new TimeSpan(2, 8, 0),
                    AgeRestriction = 16, Quantity = 4
                },
                new Movie
                {
                    Id = 11, CreatedOn = seedDate, Title = "The Understudy",
                    Genre = Genre.Drama, Language = Language.Italian, IsAvailable = true,
                    ReleaseDate = new DateTime(2019, 8, 9), Length = new TimeSpan(1, 50, 0),
                    AgeRestriction = 12, Quantity = 3
                },
                new Movie
                {
                    Id = 12, CreatedOn = seedDate, Title = "Comedy of Errors, Seoul",
                    Genre = Genre.Comedy, Language = Language.Korean, IsAvailable = true,
                    ReleaseDate = new DateTime(2020, 12, 25), Length = new TimeSpan(1, 48, 0),
                    AgeRestriction = 0, Quantity = 5
                }
            };

            var casts = new List<Cast>
            {
                new Cast { Id = 1, CreatedOn = seedDate, MovieId = 1, Name = "James Colton", PartName = Part.Actor },
                new Cast { Id = 2, CreatedOn = seedDate, MovieId = 1, Name = "Lena Ford", PartName = Part.Director },
                new Cast { Id = 3, CreatedOn = seedDate, MovieId = 2, Name = "Priya Shah", PartName = Part.Actor },
                new Cast { Id = 4, CreatedOn = seedDate, MovieId = 3, Name = "Boris Nikolov", PartName = Part.Actor },
                new Cast { Id = 5, CreatedOn = seedDate, MovieId = 3, Name = "Irina Volkova", PartName = Part.Writer },
                new Cast { Id = 6, CreatedOn = seedDate, MovieId = 4, Name = "Grace Whitmore", PartName = Part.Actor },
                new Cast { Id = 7, CreatedOn = seedDate, MovieId = 5, Name = "Klaus Berger", PartName = Part.Director },
                new Cast { Id = 8, CreatedOn = seedDate, MovieId = 6, Name = "Camille Laurent", PartName = Part.Actor },
                new Cast { Id = 9, CreatedOn = seedDate, MovieId = 7, Name = "Owen Marsh", PartName = Part.Actor },
                new Cast { Id = 10, CreatedOn = seedDate, MovieId = 9, Name = "Haruto Sato", PartName = Part.Composer },
                new Cast { Id = 11, CreatedOn = seedDate, MovieId = 10, Name = "Diego Ramirez", PartName = Part.Actor },
                new Cast { Id = 12, CreatedOn = seedDate, MovieId = 12, Name = "Ji-ho Park", PartName = Part.Actor }
            };

            var rentals = new List<Rental>
            {
                new Rental { Id = 1, CreatedOn = seedDate, MovieId = 1, UserId = 1, RentedOn = seedDate.AddDays(-2), ReturnedOn = seedDate.AddDays(-1) },
                new Rental { Id = 2, CreatedOn = seedDate, MovieId = 5, UserId = 1, RentedOn = seedDate.AddDays(-5), ReturnedOn = null },
                new Rental { Id = 3, CreatedOn = seedDate, MovieId = 4, UserId = 2, RentedOn = seedDate.AddDays(-1), ReturnedOn = null }
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