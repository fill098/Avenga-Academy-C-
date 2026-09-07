using NotesApp.DataAccess.Interfaces;
using NotesApp.Domain.Models;
using NotesApp.Dtos;
using NotesApp.Services.CustomExceptions;
using NotesApp.Services.Interfaces;

namespace NotesApp.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;


        public async Task<UserDto> RegisterAsync(RegisterDto registerDto)
        {
            ValidateRegistration(registerDto);

            bool usernameExists = await _userRepository.CheckUsernameExistsAsync(registerDto.Username);

            if (usernameExists)
            {
                throw new UserDataException($"Username {registerDto.Username} is already taken.");
            }


            string passwordHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password);

            User newUser = new User
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Username = registerDto.Username,
                Password = passwordHash
            };

            await _userRepository.AddAsync(newUser);

            return new UserDto
            {
                Id = newUser.Id,
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Username = newUser.Username
            };
        }

        private void ValidateRegistration(RegisterDto registerDto)
        {
            if (string.IsNullOrWhiteSpace(registerDto.FirstName) || registerDto.FirstName.Length > 100)
            {
                throw new UserDataException("First name is required and should not exceed 100 characters.");
            }
            if (string.IsNullOrWhiteSpace(registerDto.LastName) || registerDto.LastName.Length > 100)
            {
                throw new UserDataException("Last  name is required and should not exceed 100 characters.");
            }
            if (string.IsNullOrWhiteSpace(registerDto.Username) || registerDto.Username.Length > 30)
            {
                throw new UserDataException("Username  is required and should not exceed 30 characters.");
            }

            if (registerDto.Password.Length > 8)
            {
                throw new UserDataException("Password must be at least 8 character");
            }

            if (registerDto.Password != registerDto.ConfirmPassword)
            {
                throw new UserDataException("Password do not match.");
            }
        }
    }
}
