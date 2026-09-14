using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NotesApp.DataAccess.Implementations.EntityFramework;
using NotesApp.DataAccess.Interfaces;
using NotesApp.Services.Configuration;
using NotesApp.Services.Implementations;
using NotesApp.Services.Interfaces;
using System.Text;

namespace NotesApp.Helpers;

public static class DependencyInjectionHelper
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<INoteRepository, NoteRepository>(); // EF Core
        //services.AddScoped<INoteRepository, NoteRepositoryAdoNet>(); // ADO.NET
        //services.AddScoped<INoteRepository, NoteRepositoryDapper>(); // Dapper 
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
    }

    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<INoteService, NoteService>();
        services.AddScoped<IAuthService, AuthService>();

    }

    public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        IConfiguration jwtSection = configuration.GetSection("JwtSettings");
        services.Configure<JwtSettings>(jwtSection);

        JwtSettings jwtSettings = jwtSection.Get<JwtSettings>();

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })

        .AddJwtBearer(options =>
         {
             options.TokenValidationParameters = new TokenValidationParameters
             {
                 ValidateIssuerSigningKey = true,
                 IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SeccretKey)),

                 ValidateIssuer = true,
                 ValidIssuer = jwtSettings.Issuer,
                 ValidateAudience = true,
                 ValidAudience = jwtSettings.Audience,

                 ValidateLifetime = true,

                 ClockSkew = TimeSpan.Zero,

             };
         });
    }
}
