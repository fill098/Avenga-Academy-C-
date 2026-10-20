using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Domain.Entities;
using PizzaApp.Dtos.Users;
using PizzaApp.Services.Abstractions;
using PizzaApp.Shared.Exceptions;

namespace PizzaApp.Services.Implementations;

public class UserService : IUserService
{
    private readonly ICurrentUser _currentUser;

    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    #region LoginInUser
    public UserService(ICurrentUser currentUser, IMapper mapper, UserManager<User> userManager)
    {
        _currentUser = currentUser;
        _mapper = mapper;
        _userManager = userManager;
    }
    public async Task<UserDto> GetCurrentUserAsync()
    {
        var user = await FindUserIdAsync(_currentUser.Id);
            

        var userDto = _mapper.Map<UserDto>(user);
        var userRoles = await _userManager.GetRolesAsync(user);
        userDto.Roles = [.. userRoles];

        return userDto;
    }
    public async Task ChangeCurrentUserPasswordAsync(ChangePasswordDto request)
    {
        var user = await FindUserIdAsync(_currentUser.Id); ;

        var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(error => error.Description);
            throw new BadRequestException("Changing the password faild.", errors);
        }



    }
    public async Task<UserDto> UpdateCurrentUserAsync(UpdateUserDto request)
    {
        var user = await FindUserIdAsync(_currentUser.Id);

        user.UserName = request.UserName;
        user.Email = request.Email;

        var result = await _userManager.UpdateAsync(user);

        ThrowIfFailed(result, "Updating the user failed.");
        var userDto = await ToUserDtoAsync(user);

        return userDto;
    }
    public async Task DeleteCurrentUserAsync()
    {
        var user = await FindUserIdAsync(_currentUser.Id);
        var result = await _userManager.DeleteAsync(user);
        ThrowIfFailed(result, "Deleting the user failed");
    }

    #endregion

    #region Admin only
    public async Task<List<UserDto>> GetAllAsync()
    {
    
        var users = await _userManager.Users
            .AsNoTracking()
            .OrderBy(user => user.UserName)
            .ToListAsync();

        var userDtos = new List<UserDto>();

        foreach (var user in users)
        {
            userDtos.Add(await ToUserDtoAsync(user));
        }

        return userDtos;
    }


    
    public async Task<UserDto> GetByIdAsync(string id)
    {
       var user = await FindUserIdAsync(id);
        return await ToUserDtoAsync(user);
    }
    public Task<UserDto> SetRoleAsync(string id, string rool) => throw new NotImplementedException();
    public Task DeleteAsync(string id) => throw new NotImplementedException();

    #endregion

    #region Private Helpers
    private async Task<User> FindUserIdAsync(string id)
    {
        return await _userManager.FindByIdAsync(_currentUser.Id)
             ?? throw new NotFoundException(nameof(User), _currentUser.Id);
    }

    private static void ThrowIfFailed(IdentityResult result, string message)
    {
        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(error => error.Description);
            throw new BadRequestException(message, errors);
        }
    }

    private async Task<UserDto> ToUserDtoAsync(User user)
    {
        var userDto = _mapper.Map<UserDto>(user);
        var userRoles = await _userManager.GetRolesAsync(user); // ["Admin", "Customer"]
        userDto.Roles = [.. userRoles];
        return userDto;
    }


    #endregion
}
