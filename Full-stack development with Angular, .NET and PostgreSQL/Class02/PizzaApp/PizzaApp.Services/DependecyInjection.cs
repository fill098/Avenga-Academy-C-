using Microsoft.Extensions.DependencyInjection;
using PizzaApp.Services.Abstractions;
using PizzaApp.Services.Implementations;

namespace PizzaApp.Services
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenSevice, TokenService>();
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
