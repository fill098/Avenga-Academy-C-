using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccess;
using ToDoApp.DataAccess.Implementations;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;
using ToDoApp.Services.Implementations;
using ToDoApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registerd DbContext with SQL Server provider

string connectionString = builder.Configuration.GetConnectionString("ToDoAppConectionString");
builder.Services.AddDbContext<ToDoAppDbContext>(options =>
    options.UseSqlServer(connectionString));

//Dependency Injection for Repositories
builder.Services.AddScoped<IRepository<ToDo>, ToDoRepository>();
builder.Services.AddScoped<IRepository<Category>, CategoryRepository>();
builder.Services.AddScoped<IRepository<Status>, StatusRepository>();

// Dependency Injection for Services
builder.Services.AddScoped<IToDoService, ToDoService>();
builder.Services.AddScoped<IFilterService, FilterService>();

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

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
