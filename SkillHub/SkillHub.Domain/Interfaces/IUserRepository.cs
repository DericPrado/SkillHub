using SkillHub.Domain.Entities;

namespace SkillHub.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByIdAsync(Guid id);
        Task<bool> ExistsByEmailAsync(string email);
    }
}
