using PizzaApp.Dtos.Auth;
using PizzaApp.Dtos.User;

namespace PizzaApp.Services.Abstractions;

public interface IAuthService
{
    Task<UserDto> RegisterAsync(RegisterRequsetDto requset);
    Task<LoginResponsDto> LoginAsync(LoginRequestDto requset);
}
