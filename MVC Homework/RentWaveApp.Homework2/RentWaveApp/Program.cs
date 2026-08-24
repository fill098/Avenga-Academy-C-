using Microsoft.EntityFrameworkCore;
using RentWaveApp.DataAccess;
using RentWaveApp.DataAccess.Imlementations;
using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;
using RentWaveApp.Services.Imlementations;
using RentWaveApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// SQL connection string
var connectionString = builder.Configuration.GetConnectionString("DemoData");
builder.Services.AddDbContext<RentWaveDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

// Dependency Injection for Repository
builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddScoped<IRepository<Subscription>, SubscriptionRepository>();
builder.Services.AddScoped<IRepository<Rental>, RentalRepository>();
builder.Services.AddScoped<IRepository<Movie>, MovieRepository>();
builder.Services.AddScoped<IRepository<Cast>, CastRepository>();

// Dependency Injection for Services
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IRentalService, RentalService>();
builder.Services.AddScoped<IUserService, UserService>();

// Session uses under the hood to actually store data
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");


app.Run();
