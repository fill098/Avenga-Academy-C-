using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using PizzaApp.Domain.Entities;
using PizzaApp.Services.Abstractions;
using PizzaApp.Services.Models;
using PizzaApp.Shared.Settings;
using System.Security.Claims;
using System.Text;

namespace PizzaApp.Services.Implementations
{
    public class TokenService : ITokenSevice
    {
        private readonly JwtSettings _jwtSettings;
        public TokenService(IOptions<JwtSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }
        public TokenResult CreateToken(User user, IEnumerable<string> roles)
        {
            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, user.Id),
                new(JwtRegisteredClaimNames.Name, user.UserName ?? string.Empty),
                new(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),

            };

            claims.AddRange(roles.Select(role => new Claim(JwtSettings.RoleClaimType, role)));

            DateTime expireAt = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpartionInMinuts);

            SymmetricSecurityKey signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));

            SecurityTokenDescriptor tokenDiscriptor = new()
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = _jwtSettings.Issuer,
                Audience = _jwtSettings.Audience,
                Expires = expireAt,
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            };

            JsonWebTokenHandler tokenHandler = new();

            string token = tokenHandler.CreateToken(tokenDiscriptor);

            return new TokenResult(token, expireAt);
        }
    }
}
