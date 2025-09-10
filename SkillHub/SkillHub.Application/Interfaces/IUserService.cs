using SkillHub.Application.DTOs.Users;

namespace SkillHub.Application.Interfaces
{
    public interface IUserService
    {
        Task<RegisterUserResponse> RegisterAsync(RegisterUserRequest request);
        Task<UpdateUserResponse> UpdateAsync(UpdateUserRequest request);
        Task<DeleteUserResponse> DeleteAsync(DeleteUserRequest request);
    }
}
