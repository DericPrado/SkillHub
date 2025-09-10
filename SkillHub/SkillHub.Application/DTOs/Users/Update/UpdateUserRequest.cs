namespace SkillHub.Application.DTOs.Users
{
    public class UpdateUserRequest
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
    }
}