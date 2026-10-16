using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using PizzaApp.Domain.Constatns;
using PizzaApp.Domain.Entities;
using PizzaApp.Dtos.Auth;
using PizzaApp.Dtos.User;
using PizzaApp.Services.Abstractions;
using PizzaApp.Services.Models;
using PizzaApp.Shared.Exceptions;

namespace PizzaApp.Services.Implementations;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userMenager;

    private readonly ITokenSevice _tokenService;

    private readonly IMapper _mapper;

    public AuthService(ITokenSevice tokenSevice, UserManager<User> user, IMapper mapper)
    {
        _tokenService = tokenSevice;
        _userMenager = user;
        _mapper = mapper;
    }
    public async Task<UserDto> RegisterAsync(RegisterRequsetDto requset)
    {
        var user = new User
        {
            UserName = requset.UserName,
            Email = requset.Email,
        };

        IdentityResult result = await _userMenager.CreateAsync(user, requset.Password);

        if (!result.Succeeded)
        {
            throw new BadRequestException("Registration failed.", result.Errors.Select(error => error.Description));
            //throw new Exception("Registration failed.");
        }

        await _userMenager.AddToRoleAsync(user, Roles.Customer);

        var userDto = _mapper.Map<UserDto>(user);
        userDto.Roles = [Roles.Customer];

        return userDto;
    }

    public async Task<LoginResponsDto> LoginAsync(LoginRequestDto requset)
    {
        User? user = await _userMenager.FindByNameAsync(requset.UserName);

        if (user is null || !await _userMenager.CheckPasswordAsync(user, requset.Password))
        {
            throw new UnauthorizedException("Invalid username or password.");

        }

        var roles = await _userMenager.GetRolesAsync(user);
        TokenResult tokenResult = _tokenService.CreateToken(user, roles);

        return new LoginResponsDto
        {
            Token = tokenResult.Token,
            ExpiresAt = tokenResult.EXpiresEt,
            UserName = user.UserName,
            Roles = [.. roles]
        };
    }
}
