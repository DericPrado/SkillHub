using SkillHub.Application.DTOs.Users;
using SkillHub.Application.Interfaces;
using SkillHub.Domain.Entities;
using SkillHub.Domain.Interfaces;

namespace SkillHub.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<RegisterUserResponse> RegisterAsync(RegisterUserRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ArgumentException("Name is required.");

            if (string.IsNullOrWhiteSpace(request.Email))
                throw new ArgumentException("Email is required.");

            if (string.IsNullOrWhiteSpace(request.Password) || request.Password.Length < 6)
                throw new ArgumentException("Password must be at least 6 characters.");

            var userExists = await _userRepository.ExistsByEmailAsync(request.Email);
            if (userExists)
                throw new InvalidOperationException("User with this email already exists.");

            var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Password = passwordHash,
                Bio = request.Bio,
                CreatedAt = DateTime.UtcNow
            };

            await _userRepository.AddAsync(user);

            return new RegisterUserResponse
            {
                Id = user.Id,
                Email = user.Email
            };
        }
    }
}
