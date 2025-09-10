using Microsoft.EntityFrameworkCore;
using SkillHub.Domain.Entities;
using SkillHub.Domain.Interfaces;

namespace SkillHub.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SkillHubDbContext _context;

        public UserRepository(SkillHubDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(User user)
        {
            // await _context.Users.AddAsync(user);
            // await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> GetByEmailAsync(string email)
        {
            // return await _context.Users
            //     .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
            return true;
        }

        public async Task<bool> GetByIdAsync(Guid id)
        {
            // return await _context.Users.FindAsync(id);
            return true;
        }

        public async Task<bool> ExistsByEmailAsync(string email)
        {
            //return await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
            return false;
        }
    }
}
