using SkillHub.Domain.Entities;

namespace SkillHub.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> AddAsync(User user);
        Task<bool> GetByEmailAsync(string email);
        Task<bool> GetByIdAsync(Guid id);
        Task<bool> ExistsByEmailAsync(string email);
    }
}
