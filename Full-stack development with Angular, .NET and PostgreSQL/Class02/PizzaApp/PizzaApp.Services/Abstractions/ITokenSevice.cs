using PizzaApp.Domain.Entities;
using PizzaApp.Services.Models;

namespace PizzaApp.Services.Abstractions
{
    public interface ITokenSevice
    {
        TokenResult CreateToken(User user, IEnumerable<string> roles);
    }
}
