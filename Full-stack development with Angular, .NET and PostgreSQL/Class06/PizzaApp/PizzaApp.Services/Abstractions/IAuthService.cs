using PizzaApp.Dtos.Auth;
using PizzaApp.Dtos.Users;


namespace PizzaApp.Services.Abstractions;

public interface IAuthService
{
    Task<UserDto> RegisterAsync(RegisterRequsetDto requset);
    Task<LoginResponsDto> LoginAsync(LoginRequestDto requset);
}
