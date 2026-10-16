using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaApp.DataAccess.Context;
using PizzaApp.DataAccess.Repositories.Abstractions;
using PizzaApp.DataAccess.Repositories.Implementations;
using PizzaApp.DataAccess.Repositories.Implemntations;
using PizzaApp.Domain.Entities;

namespace PizzaApp.DataAccess;

public static class DependencyInjection
{

    public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PizzaAppDb");

        //Database
        services.AddDbContext<PizzaAppDbContext>(options => options.UseNpgsql(connectionString));

        // Identity: UserManager<User> and RoleManager<IdentityRole>, stored through our DbContext
        services.AddIdentityCore<User>(options => options.User.RequireUniqueEmail = true)
           .AddRoles<IdentityRole>()
           .AddEntityFrameworkStores<PizzaAppDbContext>();

        // Repositories
        services.AddScoped<IPizzaRepository, PizzaRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        return services;

    }

}
