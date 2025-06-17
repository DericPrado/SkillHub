namespace SkillHub.Application.DTOs.Users
{
    public class RegisterUserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = "User successfully registered!";
    }
}
