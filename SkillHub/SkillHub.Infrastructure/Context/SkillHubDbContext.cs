using Microsoft.EntityFrameworkCore;
using SkillHub.Domain.Entities;

public class SkillHubDbContext : DbContext
{
    public SkillHubDbContext(DbContextOptions<SkillHubDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SkillHubDbContext).Assembly);
    }
}
