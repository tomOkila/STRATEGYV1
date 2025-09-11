using Microsoft.EntityFrameworkCore;
using STRATEGY.CLIENT.Models;

namespace STRATEGY.WEBAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUsers> Users { get; set; }
        public DbSet<AppRoles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pillar> Pillars { get; set; }
        public DbSet<StrategicObjective> StrategicObjectives { get; set; }
        public DbSet<DetailedSO> DetailedSO { get; set; }
        public DbSet<ProgramSchedule> ProgramSchedules { get; set; }
        public DbSet<StrategicPlan> StrategicPlans { get; set; }
        public DbSet<Plan> Plans { get; set; }
    }
}
